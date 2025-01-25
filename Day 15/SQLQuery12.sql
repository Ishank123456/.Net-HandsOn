Create table TestEmp
(
EmpId int,
EmpName varchar(50)
)

Create table TestEmpSal
(
EmpId int,
EmpSal numeric(10, 2)
)

Insert into TestEmp(EmpId, EmpName) values (1, 'Rahul')
Insert into TestEmp(EmpId, EmpName) values (2, 'Somnath')
Insert into TestEmp(EmpId, EmpName) values (3, 'Subham')
Insert into TestEmp(EmpId, EmpName) values (4, 'Preeti')
Insert into TestEmp(EmpId, EmpName) values (5, 'Vinay')
Insert into TestEmp(EmpId, EmpName) values (9, 'Davis')

Insert into TestEmpSal(EmpId, EmpSal) values (1, 10000)
Insert into TestEmpSal(EmpId, EmpSal) values (2, 15000)
Insert into TestEmpSal(EmpId, EmpSal) values (4, 20000)
Insert into TestEmpSal(EmpId, EmpSal) values (7, 25000)
Insert into TestEmpSal(EmpId, EmpSal) values (8, 30000)
Insert into TestEmpSal(EmpId, EmpSal) values (9, 35000)

Select * from TestEmp
Select * from TestEmpSal


Select e1.empId, e1.empName, e2.empSal
from TestEmp as e1
inner join
TestEmpSal as e2
on
e1.empId = e2.empId

Select e1.empId, e1.empName, e2.empId, e2.empSal
from TestEmp as e1
Left Join
TestEmpSal as e2
on
e1.empId = e2.empId

Select e1.empId, e1.empName, e2.empId, e2.empSal
from TestEmp as e1
Right Join
TestEmpSal as e2
on
e1.empId = e2.empId

Select e1.empId, e1.empName, e2.empId, e2.empSal
from TestEmp as e1
Full Outer Join
TestEmpSal as e2
on
e1.empId = e2.empId
