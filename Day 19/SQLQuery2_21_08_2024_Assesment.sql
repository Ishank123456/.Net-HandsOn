Create Procedure SelectEmployeeDetails
AS
BEGIN
Select * from Employee
END

exec SelectEmployeeDetails


Create Procedure SelectEmployeeDetailsWithID
(
@EmpId int
)
AS
BEGIN
Select * from Employee Where EmpId = @EmpId
END

exec SelectEmployeeDetailsWithID 1


--drop procedure InsertEmployeeDetails
Create Procedure InsertEmployeeDetails
(
@EmpName varchar(50),
@EmpSal decimal(10, 2),
@EmpEmail varchar(50),
@EmpCity varchar(20),
@EmpAge int,
@EmpQualification varchar(50),
@DeptId int
)
AS
BEGIN
Insert into Employee(EmpName, EmpSal, EmpEmail, EmpCity, EmpAge, EmpQualification, DeptId)
values(@EmpName, @EmpSal, @EmpEmail, @EmpCity, @EmpAge, @EmpQualification, @DeptId)
END

exec InsertEmployeeDetails 'Priya', 70000, 'priya@gmail.com', 'Mumbai', 26, 'M. Tech', 3


--drop procedure UpdateEmployeeDetails
Create Procedure UpdateEmployeeDetails
(
@EmpId int,
@EmpName varchar(50),
@EmpSal decimal(10, 2),
@EmpEmail varchar(50),
@EmpCity varchar(20),
@EmpAge int,
@EmpQualification varchar(50),
@DeptId int
)
AS
BEGIN
Update Employee
	Set EmpName = @EmpName,
		EmpSal = @EmpSal,
		EmpEmail = @EmpEmail,
		EmpCity = @EmpCity,
		EmpAge = @EmpAge,
		EmpQualification = @EmpQualification,
		DeptId = @DeptId
	Where EmpId = @EmpId
END

exec UpdateEmployeeDetails 2, 'Moupriya', 75000, 'mou768@gmail.com', 'Adra', 27, 'MBBS', 2


Create Procedure DeleteEmployeeDetails
(
@EmpId int
)
AS
BEGIN
Delete Employee Where EmpId = @EmpId
END

exec DeleteEmployeeDetails 2