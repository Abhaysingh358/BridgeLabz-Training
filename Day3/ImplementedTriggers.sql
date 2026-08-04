create database HealthClinic;
Go;

use HealthClinic;

Create table Doctor(
DoctorId INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(50) NOT NULL,LastName VARCHAR(50) NOT NULL,
Specialization VARCHAR(100) NOT NULL , 
 Phone Varchar(15)
);

Create table Patient(
PatientId INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(50) NOT NULL,LastName VARCHAR(50) NOT NULL,
 Age INT NOT NULL , 
 Phone Varchar(15) ,
MedicalDescription VARCHAR(MAX) NOT NULL
);

Create table Appointment(
AppointmentId INT IDENTITY(1,1) PRIMARY KEY,
DoctorID INT NOT NULL,PatientId INT NOT NULL,
AppointmentDate DATE NOT NULL ,
TimeSlot TIME NOT NULL,
Symptoms VARCHAR(400) NOT NULL ,
Status VARCHAR (50) NOT NULL,

CONSTRAINT FK_AppointmentDoctor Foreign KEY (DoctorID) REFERENCES Doctor(DoctorID) ,
CONSTRAINT FK_AppointmentPatient Foreign KEY (PatientID) REFERENCES Patient(PatientID) ,
);

-- required changes since phone number is a multivalued attribute so we need a seperate table for it and same for the patient table
ALTER TABLE Doctor
Drop COLUMN Phone;

 Create Table DoctorPhone(
 DoctorPhoneId  INT IDENTITY(1,1) PRIMARY KEY,
 DoctorId INT NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL
    
 );
 ALTER TABLE DoctorPhone 
 ADD CONSTRAINT FK_DoctorPhone_Doctor FOREIGN KEY (DoctorId) References Doctor(DoctorId) ON DELETE CASCADE;

 -- changing the patient table

ALTER TABLE Patient
Drop COLUMN Age  , Phone;

-- Add DateOfBirth and Gender columns
ALTER TABLE Patient
ADD DateOfBirth Date NOT NULL ,
Gender Varchar(2) NOT NULL;

-- now creating the phone table
CREATE TABLE PatientPhone(
    PatientPhoneId INT IDENTITY(1,1) PRIMARY KEY,
    PatientId INT NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,

    CONSTRAINT FK_PatientPhone_Patient
    FOREIGN KEY (PatientId)
    REFERENCES Patient(PatientId)
);



-- Creating indexing for doctor table  according to their specialization 
CREATE NONCLUSTERED INDEX IX_Doctor_Specialization ON Doctor(Specialization);

-- creating indexes for Patient using first name and last name
CREATE NONCLUSTERED INDEX IX_Patient_Name ON Patient (FirstName , LastName);

-- creating index on appintment 
CREATE NONCLUSTERED INDEX IX_Appointment_Date ON Appointment(AppointmentDate);


-- Craeting table "Room"
Create Table Room(
    RoomId INT IDENTITY(1,1) NOT NULL ,
     FloorNumber INT NOT NULL , 
    RoomNumber VARCHAR(4) NOT NULL,
    RoomCategory VARCHAR(50) NOT NULL
   
);

-- altering the table for some changes
ALTER TABLE Room
ADD Status VARCHAR(20) NOT NULL DEFAULT 'Available',
CONSTRAINT CHK_Room_Status CHECK (Status IN ('Available', 'Occupied', 'Maintenance', 'Cleaning'));

-- 1. Add Foreign Key column to Room table
ALTER TABLE Room
ADD DoctorId INT NULL; -- Keep NULL if a room isn't assigned to a doctor permanently

-- 2. Add Foreign Key constraint linking Room to Doctor
ALTER TABLE Room
ADD CONSTRAINT FK_Room_Doctor 
FOREIGN KEY (DoctorId) REFERENCES Doctor(DoctorId)
ON DELETE SET NULL;



--Creating a stored procedure to find doctors by their specialization
CREATE PROCEDURE GetDoctorsBySpecialization
    @Specialization VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Doctor
    WHERE Specialization = @Specialization;
END;
GO




-- Creating Doctor Log Table
CREATE TABLE DoctorAudit(
    AuditID INT IDENTITY(1,1) PRIMARY KEY ,
    DoctorId INT ,
     FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Specialization VARCHAR(100),

    ActionType VARCHAR(10) NOT NULL, -- INSERT , UPDATE , DELETE
    ActionDate DATETIME NOT NULL  DEFAULT GETDATE()
);
-- EXEC sp_rename 'DoctotAudit' , 'DoctorAudit';

-- craeting trigger for inserting
CREATE TRIGGER TRG_Doctor_Insert
ON Doctor
AFTER INSERT
AS
BEGIN

    INSERT INTO DoctorAudit (
        DoctorId,
        FirstName,
        LastName,
        Specialization,
        ActionType
    )
    SELECT
        DoctorId,
        FirstName,
        LastName,
        Specialization,
        'INSERT'
    FROM inserted;
END;
GO

-- insert some data to check the logs of the table .
INSERT INTO Doctor (FirstName, LastName, Specialization) VALUES
('Sarah', 'Jenkins', 'Cardiology'),
('Michael', 'Chen', 'Pediatrics'),
('Emily', 'Rodriguez', 'Dermatology'),
('James', 'Wilson', 'Neurology'),
('Aisha', 'Patel', 'Orthopedics'),
('David', 'Kim', 'General Practice'),
('Olivia', 'Martinez', 'Oncology'),
('Robert', 'Taylor', 'Psychiatry'),
('Sophia', 'Anderson', 'Ophthalmology'),
('William', 'Thomas', 'Radiology');

SELECT DoctorId, FirstName, LastName 
FROM Doctor;

-- inserting phone number in doctors phone table
INSERT INTO DoctorPhone (DoctorId, PhoneNumber) VALUES
(11, '555-0101'), -- Dr. Sarah Jenkins
(11, '555-0102'), -- Dr. Sarah Jenkins (Secondary)
(12, '555-0201'), -- Dr. Michael Chen
(13, '555-0301'), -- Dr. Emily Rodriguez
(14, '555-0401'), -- Dr. James Wilson
(15, '555-0501'), -- Dr. Aisha Patel
(16, '555-0601'), -- Dr. David Kim
(17, '555-0701'), -- Dr. Olivia Martinez
(18, '555-0801'), -- Dr. Robert Taylor
(19, '555-0901'), -- Dr. Sophia Anderson
(20, '555-1001'); -- Dr. William Thomas


-- 2. View the background logs created by the trigger
SELECT * FROM DoctorAudit;

CREATE TRIGGER TRG_Doctor_Update
ON Doctor
AFTER UPDATE
AS
BEGIN
INSERT INTO DoctorAudit(DoctorId ,
FirstName , LastName ,Specialization , ActionType)

SELECT DoctorId , FirstName , LastName , Specialization ,'UPDATE' from inserted;
END;
GO

-- the above audit table will only store new value but for creating complete audit table we will use old and new value
CREATE TABLE DoctorLogAudit
(
    AuditId INT IDENTITY PRIMARY KEY,
    DoctorId INT,

    OldFirstName VARCHAR(50),
    NewFirstName VARCHAR(50),

    OldLastName VARCHAR(50),
    NewLastName VARCHAR(50),

    OldSpecialization VARCHAR(100),
    NewSpecialization VARCHAR(100),

    ActionType VARCHAR(10),
    ActionDate DATETIME DEFAULT GETDATE()
);

Create Trigger TRG_DoctorLog_Insert
ON Doctor
AFTER INSERT
AS
BEGIN
    INSERT INTO DoctorLogAudit(
    DoctorId ,OldFirstName , NewFirstNAme ,
    OldLastName , NewLastName , 
    OldSpecialization ,NewSpecialization,
    ActionType
    )

    Select DoctorID ,NULL , FirstName ,
    Null ,LastName ,
    Null ,Specialization,
    'INSERT' from inserted;
END;
GO

-- trigger for update lOGS
CREATE TRIGGER TRG_DoctorLog_Update
ON Doctor 
AFTER UPDATE
AS 
BEGIN
    INSERT INTO DoctorLogAudit(
        DoctorId,
        OldFirstName,
        NewFirstName,
        OldLastName,
        NewLastName,
        OldSpecialization,
        NewSpecialization,
        ActionType)

    Select old.DoctorId ,old.FirstName , new.FirstName ,
    old.LastName ,new.LastName ,old.Specialization , new.Specialization,
    'UPDATE' From deleted old INNER JOIN inserted new  ON old.DoctorId = new.DoctorId;
END;
GO





















