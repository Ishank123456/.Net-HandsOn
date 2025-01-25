Select * from Employee

create function func_EmployeeDetails()
returns table
AS
return(Select * from Employee)

Select * from func_EmployeeDetails()


alter function func_EmployeeDetails()
returns table
AS
return(Select EmpId, EmpName from Employee)

Select * from func_EmployeeDetails()

create function func_JoinEmployeeColumnData
(
@EmpName varchar(50),
@EmpAddress varchar(50),
@EmpContact varchar(50)
)
returns nvarchar(100)
AS
BEGIN
return(Select @EmpName + ' ' + @EmpAddress + ' ' + @EmpContact)
END

Select dbo.func_JoinEmployeeColumnData(EmpName, EmpAddress, EmpContact) as Details from Employee