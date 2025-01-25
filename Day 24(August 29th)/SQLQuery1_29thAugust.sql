Create Database Wipro_29_08_2024

Use Wipro_29_08_2024

--drop table Users
create table Users
(
UserId int primary key identity(1, 1),
UserName varchar(50),
Password varchar(50),
Email varchar(50),
ModifiedDate DateTime,
IPAddress varchar(100)
)

--drop table UserProfiles
create table UserProfiles
(
UserProfileId int primary key identity(1, 1),
UserId int foreign key references Users(UserId),
FirstName varchar(50),
LastName varchar(50),
Address varchar(100),
ContactNo varchar(50)
)

Select * from Users
Select * from UserProfiles