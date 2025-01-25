CREATE TABLE TestA
(
EmpId INT,
EmpName VARCHAR(50)
)

CREATE TABLE TestB
(
EmpId INT,
DeptId INT,
DeptName VARCHAR(50)
)

INSERT INTO TestA(EmpId, EmpName) VALUES(1, 'Saurabh')
INSERT INTO TestA(EmpId, EmpName) VALUES(2, 'Sanjay')

INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(1, 1, 'Finance')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(1, 2, 'HR')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(1, 3, 'IT')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(1, 4, 'Payroll')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(2, 4, 'Payroll')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(2, 3, 'IT')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(2, 2, 'HR')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(3, 4, 'Payroll')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(3, 3, 'IT')
INSERT INTO TestB(EmpId, DeptId, DeptName) VALUES(3, 2, 'HR')

SELECT * FROM TestA
SELECT * FROM TestB

SELECT e1.EmpId, e1.EmpName, e2.DeptId, e2.DeptName
FROM TestA AS e1
INNER JOIN
TestB AS e2
ON
e1.EmpId = e2.EmpId

SELECT e1.EmpId, e1.EmpName, e2.DeptId, e2.DeptName
FROM TestA AS e1
LEFT JOIN
TestB AS e2
ON
e1.EmpId = e2.EmpId

SELECT e1.EmpId, e1.EmpName, e2.DeptId, e2.DeptName
FROM TestA AS e1
RIGHT JOIN
TestB AS e2
ON
e1.EmpId = e2.EmpId