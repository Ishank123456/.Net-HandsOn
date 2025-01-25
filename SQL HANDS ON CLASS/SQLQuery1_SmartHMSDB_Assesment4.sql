CREATE DATABASE SmartHMSDB

USE SmartHMSDB

--drop table Patients
CREATE TABLE Patients (
    PatientId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(50),
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(100),
    Address NVARCHAR(255)
);


CREATE TABLE Doctors (
    DoctorId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Specialty NVARCHAR(100),
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(100),
    OfficeLocation NVARCHAR(255)
);

Create table Users (
	UserId int primary key identity(1, 1),
	UserName varchar(50),
	Password varchar(50),
	Email varchar(50),
	FirstName varchar(50),
	LastName varchar(50),
	Address varchar(100),
	ContactNo varchar(50),
	IsAdmin int not null
);

--drop table Appointments
CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT NOT NULL,
	PatientName VARCHAR(50),
    DoctorID INT NOT NULL,
    AppointmentDate DATETIME NOT NULL,
    AppointmentStatus VARCHAR(50) NOT NULL, 
    ReasonForVisit VARCHAR(255),
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);
truncate table Appointments


Select * from Users
Select * from Patients
Select * from Doctors
Select * from Appointments

Update Users
Set IsAdmin = 1
Where UserId = 1

