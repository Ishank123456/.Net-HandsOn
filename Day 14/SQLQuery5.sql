Create table Customers
(
CustomerId int primary key identity(1, 1),
CustomerName varchar(20),
CustomerContact varchar(20),
CustomerAddress varchar(50),
CustomerCity varchar(20),
CustomerPostalCode varchar(10),
CustomerCountry varchar(20)
)

Select * from Customers
