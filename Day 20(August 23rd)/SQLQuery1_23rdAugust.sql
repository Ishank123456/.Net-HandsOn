Create Database Wipro_23_08_2024

Use Wipro_23_08_2024

--drop table Students
Create table Students
(
StudentId int primary key identity(1, 1),
StudentName varchar(50),
StudentAge int,
StudentGender varchar(10),
StudentMobileNo varchar(50),
StudentCity varchar(50)
)

Select * from Students