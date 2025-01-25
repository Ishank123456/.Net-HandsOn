--drop table Customer
Create table Customer
(
CustId int primary key identity(1, 1),
CustName varchar(50),
CustAddress varchar(50),
CustEmail varchar(50),
CustCity varchar(50)
)

Insert into Customer values('Rahul', 'India', 'rahul@gmail.com', 'Mumbai')
Insert into Customer values('Somnath', 'India', 'somnath@gmail.com', 'Banglore')
Insert into Customer values('Davis', 'USA', 'davis@gmail.com', 'Mumbai')
Insert into Customer values('Subham', 'India', 'subham@gmail.com', 'Kolkata')
Insert into Customer values('Preeti', 'India', 'preeti00@gmail.com', 'Delhi')
Insert into Customer values('Vinay', 'India', 'rahul@gmail.com', 'Noida')
Insert into Customer values('Emma', 'UK', 'rahul@gmail.com', 'London')
Insert into Customer values('Wang Xi', 'China', 'rahul@gmail.com', 'Sanghai')
Insert into Customer values('Koushik', 'India', 'rahul@gmail.com', 'Chennai')
Insert into Customer values('Akash', 'India', 'rahul@gmail.com', 'Mumbai')

--Insert
--drop procedure InsertCustomerDetails
create procedure InsertCustomerDetails
(
@CustName varchar(50),
@CustAddress varchar(50),
@CustEmail varchar(50),
@CustCity varchar(50)
)
AS
BEGIN
Insert into Customer(CustName, CustAddress, CustEmail, CustCity)
values(@CustName, @CustAddress, @CustEmail, @CustCity)
END

exec InsertCustomerDetails 'Shibam', 'India', 'shibam@gmail.com', 'Banglore'
exec InsertCustomerDetails 'Moupriya', 'India', 'mou@gmail.com', 'Mumbai'
exec InsertCustomerDetails 'Max', 'Australia', 'max@gmail.com', 'Sydney'
exec InsertCustomerDetails 'Oda', 'Japan', 'oda@gmail.com', 'Tokyo'
exec InsertCustomerDetails 'Sudip', 'India', 'sudip@gmail.com', 'Delhi'

--Select
create procedure SelectCustomer
AS
BEGIN
Select * from Customer
End

exec SelectCustomer

--Select With ID
create procedure SelectCustomerWithId
(
@CustId int 
)
AS
BEGIN
Select * from Customer Where CustId = @CustId
END

exec SelectCustomerWithId 2


--Update
create procedure UpdateCustomer
(
@CustId int,
@CustName varchar(50),
@CustAddress varchar(50),
@CustEmail varchar(50),
@CustCity varchar(50)
)
AS
BEGIN
	UPDATE Customer
	SET CustName = @CustName,
		CustAddress = @CustAddress,
		CustEmail= @CustEmail,
		CustCity = @CustCity
	WHERE CustId = @CustId
END

exec UpdateCustomer 15, 'Valmiki', 'India', 'valmiki@gmail.com', 'Dharamshala'
--Delete
create procedure DeleteCustomer
(
@CustId int
)
AS
BEGIN
Delete Customer Where CustId = @CustId
END

exec DeleteCustomer 15