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
Phone Varchar(15) , MedicalDescription VARCHAR(MAX) NOT NULL
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





