Create table Student
(
StudentId int primary key identity(1, 1),
StudentName varchar(50),
StudentEmail varchar(100),
StudentAge int,
StudentMobileNo varchar(50)
)

Insert into Student values('Subham', 'subham231@gmail.com', 24, '8617659935')

Select * from Student