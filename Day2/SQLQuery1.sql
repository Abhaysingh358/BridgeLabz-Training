create database HealthClinic;
Go;

use HealthClinic;

Create table Doctor(
DoctorId INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(50) NOT NULL,LastName VARCHAR(50) NOT NULL,
Specialization VARCHAR(100) NOT NULL , 
-- Phone Varchar(15)
);

Create table Patient(
PatientId INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR(50) NOT NULL,LastName VARCHAR(50) NOT NULL,
-- Age INT NOT NULL , 
-- Phone Varchar(15) ,
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














