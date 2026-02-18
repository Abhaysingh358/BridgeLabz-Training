create database healthCareDB;
go

USE healthCareDB;
--  PATIENTS

CREATE TABLE Patients (
    PatientId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Phone NVARCHAR(15) NOT NULL UNIQUE,
    Email NVARCHAR(100) UNIQUE,
    Address NVARCHAR(250),
    BloodGroup NVARCHAR(5),
    CreatedDate DATETIME DEFAULT GETDATE()
);

CREATE INDEX IX_Patients_Name ON Patients(FullName);
CREATE INDEX IX_Patients_Phone ON Patients(Phone);

------------------------------------------------
-- SPECIALTIES (Lookup Table)
------------------------------------------------
CREATE TABLE Specialties (
    SpecialtyId INT PRIMARY KEY IDENTITY(1,1),
    SpecialtyName NVARCHAR(100) NOT NULL UNIQUE,
    IsActive BIT DEFAULT 1
);

------------------------------------------------
-- DOCTORS
------------------------------------------------
CREATE TABLE Doctors (
    DoctorId INT PRIMARY KEY IDENTITY(1,1),
    DoctorName NVARCHAR(100) NOT NULL,
    Contact NVARCHAR(15),
    ConsultationFee DECIMAL(10,2) NOT NULL,
    SpecialtyId INT NOT NULL,
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Doctors_Specialty
    FOREIGN KEY (SpecialtyId)
    REFERENCES Specialties(SpecialtyId)
);

CREATE INDEX IX_Doctors_Specialty ON Doctors(SpecialtyId);


-- APPOINTMENTS
------------------------------------------------
CREATE TABLE Appointments (
    AppointmentId INT PRIMARY KEY IDENTITY(1,1),
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    AppointmentDate DATETIME NOT NULL,
    Status NVARCHAR(20) DEFAULT 'SCHEDULED',
    CreatedDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Appointments_Patient
    FOREIGN KEY (PatientId)
    REFERENCES Patients(PatientId),

    CONSTRAINT FK_Appointments_Doctor
    FOREIGN KEY (DoctorId)
    REFERENCES Doctors(DoctorId)
);

CREATE INDEX IX_Appointments_DoctorDate 
ON Appointments(DoctorId, AppointmentDate);


-- VISITS
------------------------------------------------
CREATE TABLE Visits (
    VisitId INT PRIMARY KEY IDENTITY(1,1),
    AppointmentId INT NOT NULL,
    Diagnosis NVARCHAR(500),
    Notes NVARCHAR(1000),
    VisitDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Visits_Appointment
    FOREIGN KEY (AppointmentId)
    REFERENCES Appointments(AppointmentId)
);


-- PRESCRIPTIONS (One-to-Many with Visits)
------------------------------------------------
CREATE TABLE Prescriptions (
    PrescriptionId INT PRIMARY KEY IDENTITY(1,1),
    VisitId INT NOT NULL,
    MedicineName NVARCHAR(100) NOT NULL,
    Dosage NVARCHAR(100),
    Duration NVARCHAR(100),

    CONSTRAINT FK_Prescriptions_Visit
    FOREIGN KEY (VisitId)
    REFERENCES Visits(VisitId)
);


-- BILLS
------------------------------------------------
CREATE TABLE Bills (
    BillId INT PRIMARY KEY IDENTITY(1,1),
    VisitId INT NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL,
    PaymentStatus NVARCHAR(20) DEFAULT 'UNPAID',
    PaymentDate DATETIME,

    CONSTRAINT FK_Bills_Visit
    FOREIGN KEY (VisitId)
    REFERENCES Visits(VisitId)
);

CREATE INDEX IX_Bills_Status ON Bills(PaymentStatus);


--  PAYMENT TRANSACTIONS
------------------------------------------------
CREATE TABLE PaymentTransactions (
    TransactionId INT PRIMARY KEY IDENTITY(1,1),
    BillId INT NOT NULL,
    PaymentMode NVARCHAR(50),
    PaidAmount DECIMAL(10,2),
    PaymentDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_PaymentTransactions_Bill
    FOREIGN KEY (BillId)
    REFERENCES Bills(BillId)
);

------------------------------------------------
--APPOINTMENT AUDIT

CREATE TABLE Appointment_Audit (
    AuditId INT PRIMARY KEY IDENTITY(1,1),
    AppointmentId INT,
    ActionType NVARCHAR(50),
    ActionDate DATETIME DEFAULT GETDATE()
);


-- SYSTEM AUDIT LOG
------------------------------------------------
CREATE TABLE Audit_Log (
    AuditId INT PRIMARY KEY IDENTITY(1,1),
    TableName NVARCHAR(100),
    ActionType NVARCHAR(50),
    PerformedBy NVARCHAR(100),
    ActionDate DATETIME DEFAULT GETDATE()
);
