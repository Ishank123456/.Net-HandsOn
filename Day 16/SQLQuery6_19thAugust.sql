Create Database Wipro_19th_August

Use Wipro_19th_August

Create table Employee
(
EmpId int primary key,
EmpName varchar(100),
Department varchar(50),
ContactNo bigint,
EmailId varchar(100),
EmpHeadId int
)

Insert into Employee values(101, 'Isha', 'E-101', 1234567890, 'isha@gmail.com', 105)
Insert into Employee values(102, 'Priya', 'E-104', 1234567890, 'priya@gmail.com', 103)
Insert into Employee values(103, 'Neha', 'E-101', 1234567890, 'neha@gmail.com', 101)
Insert into Employee values(104, 'Rahul', 'E-102', 1234567890, 'rahul@gmail.com', 105)
Insert into Employee values(105, 'Abhisek', 'E-101', 1234567890, 'abhisek@gmail.com', 102)

Select * from Employee

Create table EmpDept
(
DeptId varchar(50) primary key,
DeptName varchar(100),
Dept_off varchar(100),
DeptHead int foreign key references Employee(EmpId)
)

Insert into EmpDept values('E-101', 'HR', 'Monday', 105)
Insert into EmpDept values('E-102', 'Development', 'Tuesday', 101)
Insert into EmpDept values('E-103', 'House Keeping', 'Saturday', 103)
Insert into EmpDept values('E-104', 'Sales', 'Sunday', 104)
Insert into EmpDept values('E-105', 'Purchase', 'Tuesday', 104)

Select * from EmpDept

Create table EmpSalary
(
EmpId int foreign key references Employee(EmpId),
Salary bigint,
isPermanent varchar(3)
)

Insert into EmpSalary values(101, 2000, 'Yes')
Insert into EmpSalary values(102, 10000, 'Yes')
Insert into EmpSalary values(103, 5000, 'No')
Insert into EmpSalary values(104, 1900, 'Yes')
Insert into EmpSalary values(105, 2300, 'Yes')

Select * from EmpSalary

Create table Project
(
ProjectId varchar(50) primary key,
Duration int
)

Insert into Project values('P-1', 23)
Insert into Project values('P-2', 15)
Insert into Project values('P-3', 45)
Insert into Project values('P-4', 2)
Insert into Project values('P-5', 30)

Select * from Project

Create table Country
(
CId varchar(50) primary key,
CName varchar(100)
)

Insert into Country values('C-1', 'India')
Insert into Country values('C-2', 'USA')
Insert into Country values('C-3', 'UK')
Insert into Country values('C-4', 'Germany')
Insert into Country values('C-5', 'Canada')

Select * from Country

Create table ClientTable
(
ClientId varchar(50) primary key,
ClientName varchar(100),
CId varchar(50) references Country(CId)
)

Insert into ClientTable values('cl-1', 'CGI', 'C-1')
Insert into ClientTable values('cl-2', 'GENPACT', 'C-2')
Insert into ClientTable values('cl-3', 'INCEDO', 'C-3')
Insert into ClientTable values('cl-4', 'INFY', 'C-4')
Insert into ClientTable values('cl-5', 'WIPRO', 'C-5')

Select * from ClientTable

Create table EmpProject
(
EmpId int foreign key references Employee(EmpId),
ProjectId varchar(50) foreign key references Project(ProjectId),
ClientId varchar(50) foreign key references ClientTable(ClientId),
StartYear int,
EndYear int
)

Insert into EmpProject values(101, 'P-1', 'cl-1', 2010, 2010)
Insert into EmpProject values(102, 'P-2', 'cl-2', 2010, 2012)
Insert into EmpProject values(103, 'P-1', 'cl-3', 2013, '')
Insert into EmpProject values(104, 'P-4', 'cl-1', 2014, 2015)
Insert into EmpProject values(105, 'P-4', 'cl-5', 2015, '')

Select * from EmpProject


