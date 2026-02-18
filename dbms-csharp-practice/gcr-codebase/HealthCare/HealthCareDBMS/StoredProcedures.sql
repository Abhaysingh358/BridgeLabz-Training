use healthCareDB;
go
---------------------------------------------------------
-- PATIENT MANAGEMENT

-- Register Patient
CREATE PROCEDURE SPAfterInsertationRegisterPatient
    @FullName NVARCHAR(100),
    @DOB DATE,
    @Phone NVARCHAR(15),
    @Email NVARCHAR(100),
    @Address NVARCHAR(250),
    @BloodGroup NVARCHAR(5)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Patients WHERE Phone = @Phone OR Email = @Email)
    BEGIN
        RAISERROR('Patient already exists.',16,1)
        RETURN
    END

    INSERT INTO Patients
    (FullName, DateOfBirth, Phone, Email, Address, BloodGroup)
    VALUES
    (@FullName, @DOB, @Phone, @Email, @Address, @BloodGroup)
END
GO

-- Update Patient
CREATE PROCEDURE SPAfterUpdationPatientDetails
    @PatientId INT,
    @FullName NVARCHAR(100),
    @Phone NVARCHAR(15),
    @Email NVARCHAR(100),
    @Address NVARCHAR(250),
    @BloodGroup NVARCHAR(5)
AS
BEGIN
    UPDATE Patients
    SET FullName=@FullName,
        Phone=@Phone,
        Email=@Email,
        Address=@Address,
        BloodGroup=@BloodGroup
    WHERE PatientId=@PatientId
END
GO

-- Search Patient
CREATE PROCEDURE SPAfterSelectionSearchPatient
    @SearchValue NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Patients
    WHERE FullName LIKE '%' + @SearchValue + '%'
       OR Phone=@SearchValue
       OR CAST(PatientId AS NVARCHAR)=@SearchValue
END
GO

-- Visit History
CREATE PROCEDURE SPAfterSelectionPatientVisitHistory
    @PatientId INT
AS
BEGIN
    SELECT d.DoctorName,
           v.Diagnosis,
           v.VisitDate
    FROM Visits v
    INNER JOIN Appointments a ON v.AppointmentId=a.AppointmentId
    INNER JOIN Doctors d ON a.DoctorId=d.DoctorId
    WHERE a.PatientId=@PatientId
    ORDER BY v.VisitDate DESC
END
GO

---------------------------------------------------------
-- DOCTOR MANAGEMENT

-- Add Doctor
CREATE PROCEDURE SPAfterInsertationDoctorProfile
    @DoctorName NVARCHAR(100),
    @Contact NVARCHAR(15),
    @ConsultationFee DECIMAL(10,2),
    @SpecialtyId INT
AS
BEGIN
    INSERT INTO Doctors
    (DoctorName, Contact, ConsultationFee, SpecialtyId)
    VALUES
    (@DoctorName, @Contact, @ConsultationFee, @SpecialtyId)
END
GO

-- Update Doctor Specialty
CREATE PROCEDURE SPAfterUpdationDoctorSpecialty
    @DoctorId INT,
    @SpecialtyId INT
AS
BEGIN
    BEGIN TRANSACTION
    UPDATE Doctors
    SET SpecialtyId=@SpecialtyId
    WHERE DoctorId=@DoctorId
    COMMIT
END
GO

-- View Doctors by Specialty
CREATE PROCEDURE SPAfterSelectionDoctorsBySpecialty
    @SpecialtyName NVARCHAR(100)
AS
BEGIN
    SELECT d.DoctorId,d.DoctorName,d.ConsultationFee
    FROM Doctors d
    INNER JOIN Specialties s ON d.SpecialtyId=s.SpecialtyId
    WHERE s.SpecialtyName=@SpecialtyName
      AND d.IsActive=1
END
GO

-- Deactivate Doctor
CREATE PROCEDURE SPAfterUpdationDeactivateDoctor
    @DoctorId INT
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM Appointments
        WHERE DoctorId=@DoctorId
        AND AppointmentDate>GETDATE()
        AND Status='SCHEDULED'
    )
    BEGIN
        RAISERROR('Doctor has future appointments.',16,1)
        RETURN
    END

    UPDATE Doctors
    SET IsActive=0
    WHERE DoctorId=@DoctorId
END
GO

---------------------------------------------------------
-- APPOINTMENTS

-- Book Appointment
CREATE PROCEDURE SPAfterInsertationBookAppointment
    @PatientId INT,
    @DoctorId INT,
    @AppointmentDate DATETIME
AS
BEGIN
    BEGIN TRANSACTION

    IF EXISTS (
        SELECT 1 FROM Appointments
        WHERE DoctorId=@DoctorId
        AND AppointmentDate=@AppointmentDate
        AND Status='SCHEDULED'
    )
    BEGIN
        ROLLBACK
        RAISERROR('Slot already booked',16,1)
        RETURN
    END

    INSERT INTO Appointments(PatientId,DoctorId,AppointmentDate)
    VALUES(@PatientId,@DoctorId,@AppointmentDate)

    COMMIT
END
GO

-- Doctor Availability
CREATE PROCEDURE SPAfterSelectionDoctorAvailability
    @DoctorId INT,
    @Date DATE
AS
BEGIN
    SELECT AppointmentDate,
           COUNT(*) AS TotalBookings
    FROM Appointments
    WHERE DoctorId=@DoctorId
      AND CAST(AppointmentDate AS DATE)=@Date
      AND Status='SCHEDULED'
    GROUP BY AppointmentDate
END
GO

-- Cancel Appointment
CREATE PROCEDURE SPAfterUpdationCancelAppointment
    @AppointmentId INT
AS
BEGIN
    BEGIN TRANSACTION

    UPDATE Appointments
    SET Status='CANCELLED'
    WHERE AppointmentId=@AppointmentId

    INSERT INTO Appointment_Audit(AppointmentId,ActionType)
    VALUES(@AppointmentId,'CANCELLED')

    COMMIT
END
GO

-- Reschedule
CREATE PROCEDURE SPAfterUpdationRescheduleAppointment
    @AppointmentId INT,
    @NewDate DATETIME
AS
BEGIN
    BEGIN TRANSACTION

    UPDATE Appointments
    SET AppointmentDate=@NewDate
    WHERE AppointmentId=@AppointmentId

    COMMIT
END
GO

-- Daily Schedule
CREATE PROCEDURE SPAfterSelectionDailySchedule
    @Date DATE
AS
BEGIN
    SELECT p.FullName,
           d.DoctorName,
           a.AppointmentDate,
           a.Status
    FROM Appointments a
    INNER JOIN Patients p ON a.PatientId=p.PatientId
    INNER JOIN Doctors d ON a.DoctorId=d.DoctorId
    WHERE CAST(a.AppointmentDate AS DATE)=@Date
    ORDER BY a.AppointmentDate
END
GO

---------------------------------------------------------
-- VISITS & PRESCRIPTIONS

-- Record Visit
CREATE PROCEDURE SPAfterInsertationRecordVisit
    @AppointmentId INT,
    @Diagnosis NVARCHAR(500),
    @Notes NVARCHAR(500)
AS
BEGIN
    BEGIN TRANSACTION

    INSERT INTO Visits(AppointmentId,Diagnosis,Notes)
    VALUES(@AppointmentId,@Diagnosis,@Notes)

    UPDATE Appointments
    SET Status='COMPLETED'
    WHERE AppointmentId=@AppointmentId

    COMMIT
END
GO

-- Medical History
CREATE PROCEDURE SPAfterSelectionMedicalHistory
    @PatientId INT
AS
BEGIN
    SELECT v.Diagnosis,v.VisitDate
    FROM Visits v
    INNER JOIN Appointments a ON v.AppointmentId=a.AppointmentId
    WHERE a.PatientId=@PatientId
    ORDER BY v.VisitDate DESC
END
GO

-- Add Prescription
CREATE PROCEDURE SPAfterInsertationPrescriptionDetails
    @VisitId INT,
    @MedicineName NVARCHAR(100),
    @Dosage NVARCHAR(100),
    @Duration NVARCHAR(100)
AS
BEGIN
    INSERT INTO Prescriptions
    (VisitId,MedicineName,Dosage,Duration)
    VALUES(@VisitId,@MedicineName,@Dosage,@Duration)
END
GO

---------------------------------------------------------
-- BILLING

-- Generate Bill
CREATE PROCEDURE SPAfterInsertationGenerateBill
    @VisitId INT
AS
BEGIN
    DECLARE @Fee DECIMAL(10,2)

    SELECT @Fee=d.ConsultationFee
    FROM Visits v
    INNER JOIN Appointments a ON v.AppointmentId=a.AppointmentId
    INNER JOIN Doctors d ON a.DoctorId=d.DoctorId
    WHERE v.VisitId=@VisitId

    INSERT INTO Bills(VisitId,TotalAmount)
    VALUES(@VisitId,@Fee)
END
GO

-- Record Payment
CREATE PROCEDURE SPAfterUpdationRecordPayment
    @BillId INT,
    @PaymentMode NVARCHAR(50),
    @Amount DECIMAL(10,2)
AS
BEGIN
    BEGIN TRANSACTION

    UPDATE Bills
    SET PaymentStatus='PAID',
        PaymentDate=GETDATE()
    WHERE BillId=@BillId

    INSERT INTO PaymentTransactions
    (BillId,PaymentMode,PaidAmount)
    VALUES(@BillId,@PaymentMode,@Amount)

    COMMIT
END
GO

-- Outstanding Bills
CREATE PROCEDURE SPAfterSelectionOutstandingBills
AS
BEGIN
    SELECT p.FullName,
           COUNT(b.BillId) AS PendingBills,
           SUM(b.TotalAmount) AS TotalDue
    FROM Bills b
    INNER JOIN Visits v ON b.VisitId=v.VisitId
    INNER JOIN Appointments a ON v.AppointmentId=a.AppointmentId
    INNER JOIN Patients p ON a.PatientId=p.PatientId
    WHERE b.PaymentStatus='UNPAID'
    GROUP BY p.FullName
END
GO

-- Revenue Report
CREATE PROCEDURE SPAfterSelectionRevenueReport
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT d.DoctorName,
           SUM(b.TotalAmount) AS TotalRevenue
    FROM Bills b
    INNER JOIN Visits v ON b.VisitId=v.VisitId
    INNER JOIN Appointments a ON v.AppointmentId=a.AppointmentId
    INNER JOIN Doctors d ON a.DoctorId=d.DoctorId
    WHERE b.PaymentStatus='PAID'
      AND b.PaymentDate BETWEEN @StartDate AND @EndDate
    GROUP BY d.DoctorName
    HAVING SUM(b.TotalAmount)>0
END
GO

---------------------------------------------------------
-- SPECIALTY MANAGEMENT

-- Add Specialty
CREATE PROCEDURE SPAfterInsertationAddSpecialty
    @SpecialtyName NVARCHAR(100)
AS
BEGIN
    INSERT INTO Specialties(SpecialtyName)
    VALUES(@SpecialtyName)
END
GO

-- Delete Specialty
CREATE PROCEDURE SPAfterDeletionRemoveSpecialty
    @SpecialtyId INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Doctors WHERE SpecialtyId=@SpecialtyId)
    BEGIN
        RAISERROR('Specialty in use.',16,1)
        RETURN
    END

    DELETE FROM Specialties
    WHERE SpecialtyId=@SpecialtyId
END
GO
