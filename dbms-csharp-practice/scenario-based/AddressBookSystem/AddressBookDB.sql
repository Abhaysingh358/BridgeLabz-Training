CREATE DATABASE AddressBookDB;
GO

USE AddressBookDB;

CREATE TABLE Contacts
(
    Id INT IDENTITY PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Address NVARCHAR(100),
    City NVARCHAR(50),
    State NVARCHAR(50),
    Zip NVARCHAR(10),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100),
    BookName NVARCHAR(50)
);


select * From Contacts;