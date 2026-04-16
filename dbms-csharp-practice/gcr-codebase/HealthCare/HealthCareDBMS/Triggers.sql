/* 
   HEALTH CLINIC SYSTEM - ALL TRIGGERS
   */

---------------------------------------------------------
use healthCareDB ;
go

-- PATIENT AUDIT TRIGGER
CREATE TRIGGER TRGAfterInsertUpdateDeletePatients
ON Patients
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO Audit_Log(TableName, ActionType, PerformedBy)
    SELECT 'Patients',
           CASE 
               WHEN EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
                    THEN 'UPDATED'
               WHEN EXISTS (SELECT * FROM inserted)
                    THEN 'INSERTED'
               ELSE 'DELETED'
           END,
           SYSTEM_USER
END
GO

---------------------------------------------------------
--  DOCTOR AUDIT TRIGGER

CREATE TRIGGER TRGAfterInsertUpdateDeleteDoctors
ON Doctors
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO Audit_Log(TableName, ActionType, PerformedBy)
    SELECT 'Doctors',
           CASE 
               WHEN EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
                    THEN 'UPDATED'
               WHEN EXISTS (SELECT * FROM inserted)
                    THEN 'INSERTED'
               ELSE 'DELETED'
           END,
           SYSTEM_USER
END
GO

---------------------------------------------------------
-- APPOINTMENT AUDIT TRIGGER

CREATE TRIGGER TRGAfterInsertUpdateDeleteAppointments
ON Appointments
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO Audit_Log(TableName, ActionType, PerformedBy)
    SELECT 'Appointments',
           CASE 
               WHEN EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
                    THEN 'UPDATED'
               WHEN EXISTS (SELECT * FROM inserted)
                    THEN 'INSERTED'
               ELSE 'DELETED'
           END,
           SYSTEM_USER
END
GO

---------------------------------------------------------
-- VISIT INSERT TRIGGER (Auto Bill Creation)

CREATE TRIGGER TRGAfterInsertVisitAutoBill
ON Visits
AFTER INSERT
AS
BEGIN
    INSERT INTO Bills (VisitId, TotalAmount)
    SELECT i.VisitId, d.ConsultationFee
    FROM inserted i
    INNER JOIN Appointments a ON i.AppointmentId = a.AppointmentId
    INNER JOIN Doctors d ON a.DoctorId = d.DoctorId
END
GO

---------------------------------------------------------
-- BILL PAYMENT AUDIT TRIGGER : 

CREATE TRIGGER TRGAfterUpdateBillPayment
ON Bills
AFTER UPDATE
AS
BEGIN
    IF UPDATE(PaymentStatus)
    BEGIN
        INSERT INTO Audit_Log(TableName, ActionType, PerformedBy)
        SELECT 'Bills', 'PAYMENT_UPDATED', SYSTEM_USER
    END
END
GO

---------------------------------------------------------
--DOCTOR DEACTIVATION VALIDATION : 

CREATE TRIGGER TRGBeforeDoctorDeactivation
ON Doctors
INSTEAD OF UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Doctors d ON i.DoctorId = d.DoctorId
        WHERE i.IsActive = 0
          AND EXISTS (
              SELECT 1 FROM Appointments
              WHERE DoctorId = i.DoctorId
              AND AppointmentDate > GETDATE()
              AND Status = 'SCHEDULED'
          )
    )
    BEGIN
        RAISERROR('Cannot deactivate doctor with future appointments.',16,1)
        ROLLBACK TRANSACTION
        RETURN
    END

    UPDATE Doctors
    SET DoctorName = i.DoctorName,
        Contact = i.Contact,
        ConsultationFee = i.ConsultationFee,
        SpecialtyId = i.SpecialtyId,
        IsActive = i.IsActive
    FROM inserted i
    WHERE Doctors.DoctorId = i.DoctorId
END
GO

---------------------------------------------------------
-- APPOINTMENT STATUS VALIDATION : 
CREATE TRIGGER TRGPreventInvalidAppointmentStatus
ON Appointments
AFTER UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE Status NOT IN ('SCHEDULED','CANCELLED','COMPLETED')
    )
    BEGIN
        RAISERROR('Invalid appointment status.',16,1)
        ROLLBACK TRANSACTION
    END
END
GO

---------------------------------------------------------
-- PRESCRIPTION INSERT AUDIT : 
CREATE TRIGGER TRGAfterInsertPrescription
ON Prescriptions
AFTER INSERT
AS
BEGIN
    INSERT INTO Audit_Log(TableName, ActionType, PerformedBy)
    VALUES ('Prescriptions','INSERTED',SYSTEM_USER)
END
GO

---------------------------------------------------------
-- SPECIALTY DELETE VALIDATION : 

CREATE TRIGGER TRGBeforeDeleteSpecialty
ON Specialties
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM Doctors d
        INNER JOIN deleted del ON d.SpecialtyId = del.SpecialtyId
    )
    BEGIN
        RAISERROR('Cannot delete specialty in use.',16,1)
        ROLLBACK TRANSACTION
        RETURN
    END

    DELETE FROM Specialties
    WHERE SpecialtyId IN (SELECT SpecialtyId FROM deleted)
END
GO

---------------------------------------------------------
-- SYSTEM BACKUP LOGGING TRIGGER : 

CREATE TRIGGER TRGAfterInsertAuditLog
ON Audit_Log
AFTER INSERT
AS
BEGIN
    PRINT 'Audit Log Entry Created Successfully'
END
GO
