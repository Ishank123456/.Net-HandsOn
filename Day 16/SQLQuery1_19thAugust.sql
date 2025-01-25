Create Database Wipro_19_08_2024

Use Wipro_16_08_2024

CREATE table Employee1
(
EmpId int,
EmpName varchar(50),
EmpAge int,
EmpGender varchar(10),
EmpSal decimal(10, 2),
EmpCity varchar(50)
)

Insert into Employee1 values(1, 'Rahul', 28, 'Male', 70000, 'Mumbai')
Insert into Employee1 values(2, 'Somnath', 32, 'Male', 80000, 'Hyderabad')
Insert into Employee1 values(3, 'Pragati', 26, 'Female', 50000, 'Banglore')
Insert into Employee1 values(4, 'Davis', 29, 'Male', 100000, 'New York')
Insert into Employee1 values(5, 'Vinay', 25, 'Male', 15000, 'Delhi')
Insert into Employee1 values(6, 'Koushik', 56, 'Male', 95000, 'Noida')
Insert into Employee1 values(7, 'Nisha', 24, 'Female', 36000, 'Chennai')
Insert into Employee1 values(8, 'Arka', 23, 'Male', 20000, 'Toronto')
Insert into Employee1 values(9, 'Sohom', 28, 'Male', 65500, 'Banglore')
Insert into Employee1 values(10, 'Preeti', 35, 'Female', 76700, 'Kolkata')

Select * from Employee1

Go
Create procedure DeleteEmployee
(
@EmpId int
)
As
Begin
Delete from Employee1 Where EmpId = @EmpId
End
Go

exec DeleteEmployee 2
