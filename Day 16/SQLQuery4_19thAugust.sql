Create table EmployeeSalaryInfo
(
EmpId int primary key identity(1, 1),
EmpName varchar(50),
EmpSal decimal
)

Insert into EmployeeSalaryInfo values('Mondal', 20000)
Insert into EmployeeSalaryInfo values('Santosh', 70000)
Insert into EmployeeSalaryInfo values('Vivek', 40000)
Insert into EmployeeSalaryInfo values('Keerthana', 60000)
Insert into EmployeeSalaryInfo values('Subham', 50000)
Insert into EmployeeSalaryInfo values('Jai Shankar', 90000)

Select * from EmployeeSalaryInfo

With cte_salaryRanker
AS
(
Select *, DENSE_RANK() over(order by EmpSal desc)
as SalaryRank from EmployeeSalaryInfo
)

Select * from cte_salaryRanker Where SalaryRank in (2, 3)