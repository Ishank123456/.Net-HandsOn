Create table Customer
(
CustId int primary key identity(1, 1),
CustName varchar(50),
CustAge int,
CustGender varchar(10),
CustCity varchar(50),
CustEmail varchar(50)
)

Insert into Customer values('Rahul', 25, 'Male', 'Mumbai', 'rahul@gmail.com')

Select * from Customer