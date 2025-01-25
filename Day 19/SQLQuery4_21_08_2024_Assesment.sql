--drop procedure InnerJoin
Create Procedure InnerJoin
(
@EmpId int
)
AS
BEGIN
Select e1.empId, e1.empName,e1.empAge,e1.empSal,e1.empCity,e1.empEmail,e1.empQualification,
d1.deptId, d1.DeptName from
Employee as e1 
inner join 
Department as d1 
on 
e1.deptId=d1.deptId
Where
e1.EmpId = @EmpId
END

exec InnerJoin 1

