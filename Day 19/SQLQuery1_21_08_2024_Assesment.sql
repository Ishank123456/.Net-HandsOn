Create Database Wipro_21_08_2024

Use Wipro_21_08_2024

--drop table Employee
Create table Employee
(
EmpId int primary key identity(1,1),
EmpName varchar(50),
EmpSal decimal(10, 2),
EmpEmail varchar(50),
EmpCity varchar(20),
EmpAge int,
EmpQualification varchar(50),
DeptId int foreign key references Department(DeptId)
)

Insert into Employee values('Subham', 60000, 'subham021@gmail.com', 'Kolkata', 24, 'B. Tech Graduate', 1)
Select * from Employee

--drop table Department
Create table Department
(
DeptId int primary key identity(1, 1),
DeptName varchar(50)
)

Insert into Department values('IT')
Insert into Department values('HR')
Insert into Department values('Sales')
Select * from Department


--drop table Customer
Create table Customer
(
CustId int primary key identity(101, 1),
CustName varchar(50),
CustAddress varchar(100),
CustomerCountry varchar(20)
)

Insert into Customer values('Rahul', 'Delhi', 'India')
Select * from Customer