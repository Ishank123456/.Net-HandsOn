CREATE TABLE EmployeeManager
(
EmployeeId INT,
FirstName VARCHAR(50),
ManagerId INT
)

INSERT INTO EmployeeManager VALUES(1, 'Mondol', 3)
INSERT INTO EmployeeManager VALUES(2, 'Monika', 3)
INSERT INTO EmployeeManager VALUES(3, 'Keerthana', 7)
INSERT INTO EmployeeManager VALUES(4, 'Subham', 7)
INSERT INTO EmployeeManager VALUES(5, 'Santosh', 6)
INSERT INTO EmployeeManager VALUES(6, 'Viswajeet', 3)
INSERT INTO EmployeeManager VALUES(7, 'Saurabh', null)

SELECT * FROM EmployeeManager

SELECT e1.EmployeeId AS 'Emp Id', e1.FirstName AS 'Emp Name', 
e2.EmployeeId AS 'Manager Id', e2.FirstName AS 'Manager Name'
FROM EmployeeManager AS e1 JOIN
EmployeeManager AS e2 ON
e1.ManagerId = e2.EmployeeId

 