Create database Wipro_HealthcareManagement
Use Wipro_HealthcareManagement

Create table Patient
(
PatientId int primary key identity(1, 1),
FirstName varchar(50),
LastName varchar(50),
DOB DateTime,
Gender varchar(10),
Address varchar(100),
PhoneNumber varchar(50),
Email varchar(50)
)

Create table Doctor
(
DoctorId int primary key identity(100, 1),
FirstName varchar(50),
LastName varchar(50),
Specialization varchar(100),
PhoneNumber varchar(50),
Email varchar(50)
)

Create table Appointment
(
AppointmentId int primary key identity(10, 1),
PatientId int foreign key references Patient(PatientId),
DoctorId int foreign key references Doctor(DoctorId),
AppointmentDate DateTime,
Reason varchar(500),
Status varchar(50)
)

Create table Billing
(
BillingId int,
AppointmentId int foreign key references Appointment(AppointmentId),
Amount decimal(10, 2),
PaymentStatus varchar(50),
BillingDate DateTime
)

Select * from Patient
Select * from Doctor
Select * from Appointment
Select * from Billing

