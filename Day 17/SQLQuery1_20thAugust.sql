Create Database Wipro_20_08_2024

Use Wipro_20_08_2024

Create table Employee
(
EmpId int primary key identity(1, 1),
EmpName varchar(50),
EmpAddress varchar(50),
EmpContact varchar(20),
EmpSalary decimal(10, 2)
)

Insert into Employee values('Geeta', 'Seatle', '+1 560 789 890', 90000)
Insert into Employee values('Rahul', 'Mumbai', '8617659935', 70000)

Select * from Employee