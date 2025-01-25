--drop procedure SelectCustomerDetails
Create Procedure SelectCustomerDetails
AS
BEGIN
Select * from Customer
END

exec SelectCustomerDetails

--drop procedure SelectCustomerDetailsWithID
Create Procedure SelectCustomerDetailsWithID
(
@CustId int
)
AS
BEGIN
Select * from Customer Where CustId = @CustId
END

exec SelectCustomerDetailsWithID 101


--drop procedure InsertCustomerDetails
Create Procedure InsertCustomerDetails
(
@CustName varchar(50),
@CustAddress varchar(100),
@CustomerCountry varchar(20)
)
AS
BEGIN
Insert into Customer(CustName, CustAddress, CustomerCountry)
values(@CustName, @CustAddress, @CustomerCountry)
END

exec InsertCustomerDetails 'Vinay', 'jaipur', 'India'


--drop procedure UpdateCustomerDetails
Create Procedure UpdateCustomerDetails
(
@CustId int,
@CustName varchar(50),
@CustAddress varchar(100),
@CustomerCountry varchar(20)
)
AS
BEGIN
Update Customer
	Set CustName = @CustName,
		CustAddress = @CustAddress,
		CustomerCountry = @CustomerCountry
	Where CustId = @CustId
END

exec UpdateCustomerDetails 102, 'Davis', 'New York', 'USA'

--drop procedure DeleteCustomerDetails
Create Procedure DeleteCustomerDetails
(
@CustId int
)
AS
BEGIN
Delete Customer Where CustId = @CustId
END

exec DeleteCustomerDetails 102