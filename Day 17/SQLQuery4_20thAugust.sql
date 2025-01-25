--Select
CREATE PROCEDURE SelectStudentDetails
AS
BEGIN
Select StudentId, StudentName, StudentEmail, StudentAge, StudentMobileNo from Student
END

exec SelectStudentDetails


--Select With ID
CREATE PROCEDURE SelectStudentDetailsWithId
(
@StudentId int
)
AS
BEGIN
Select StudentId, StudentName, StudentEmail, StudentAge, StudentMobileNo from Student
Where StudentId = @StudentId
END

exec SelectStudentDetailsWithId 1


--Insert
CREATE PROCEDURE InsertStudentDetails
(
@StudentName varchar(50),
@StudentEmail varchar(100),
@StudentAge int,
@StudentMobileNo varchar(50)
)
AS
BEGIN
Insert into Student(StudentName, StudentEmail, StudentAge, StudentMobileNo)
values(@StudentName, @StudentEmail, @StudentAge, @StudentMobileNo)
END

exec InsertStudentDetails 'Rahul', 'rahul@gmail.com', 21, '8956321456'
exec InsertStudentDetails 'Moupriya', 'mou@gmail.com', 20, '7856329856'


--Update
CREATE PROCEDURE UpdateStudentDetails
(
@StudentId int,
@StudentName varchar(50),
@StudentEmail varchar(100),
@StudentAge int,
@StudentMobileNo varchar(50)
)
AS
BEGIN
	Update Student
	Set StudentName = @StudentName,
		StudentEmail = @StudentEmail,
		StudentAge = @StudentAge,
		StudentMobileNo =@StudentMobileNo
	Where StudentId = @StudentId
END

exec UpdateStudentDetails 1, 'Pranay', 'pranay@gmail.com', 22,  '9826354715'


--Delete
CREATE PROCEDURE DeleteStudentDetails
(
@StudentId int
)
AS
BEGIN
Delete Student Where StudentId = @StudentId
END

exec DeleteStudentDetails 3