Use Wipro_19th_August
---Select the detail of the employee whose name starts with P.
Select * from Employee Where EmpName like 'P%'


---How many permanent candidate take salary more than 5000
Select Count(*) as 'Counter' from EmpSalary Where Salary > 5000 and isPermanent = 'Yes'


--Select the Details of the Employee who work either for department E-104 or E-102
Select * from Employee Where Department = 'E-104' or Department = 'E-102'


--What is the Department name for DeptId E-102?
Select DeptName from EmpDept Where DeptId = 'E-102'


--What is total salary that is paid to permanent employees
Select SUM(Salary) as 'Total Salary' from EmpSalary Where isPermanent = 'Yes'


--List name of all employees whose name starts with a
Select EmpName from Employee Where EmpName like 'a%'





----Procedure Practicing
--Select
create procedure SelectEmployee
As
Begin
Select * from Employee
End

exec SelectEmployee


--Select With ID
create procedure SelectEmployeeWithId
(
@EmpId int 
)
As
Begin
Select * from Employee Where EmpId = @EmpId
End

exec SelectEmployeeWithId 102


--Insert
create procedure InsertEmployee
(
@EmpId int,
@EmpName varchar(100),
@Department varchar(50),
@ContactNo bigint,
@EmailId varchar(100),
@EmpHeadId int
)
As
Begin
Insert into Employee(EmpId, EmpName, Department, ContactNo, EmailId, EmpHeadId)
values(@EmpId, @EmpName, @Department, @ContactNo, @EmailId, @EmpHeadId)
END

exec InsertEmployee 106, 'Samay', 'E-105', 1234567890, 'samay@gmail.com', 104


--Update
create procedure UpdateEmployee
(
@EmpId int,
@EmpName varchar(100),
@Department varchar(50),
@ContactNo bigint,
@EmailId varchar(100),
@EmpHeadId int
)
AS
BEGIN
	UPDATE Employee
	SET EmpName = @EmpName,
		Department = @Department,
		ContactNo = @ContactNo,
		EmailId = @EmailId,
		EmpHeadId = @EmpHeadId
	WHERE EmpId = @EmpId
END

exec UpdateEmployee 106, 'Shantanu', 'E-103', 1234567890, 'shantanu@gmail.com', 102


--Delete
create procedure DeleteEmployee
(
@EmpId int
)
AS
BEGIN
Delete Employee Where EmpId = @EmpId
END

exec DeleteEmployee 106