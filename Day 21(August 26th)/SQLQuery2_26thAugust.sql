Create table Customers
(
CustomerId int primary key identity(1, 1),
CustomerName varchar(50),
CustomerEmail varchar(50),
CustomerOrderHistory varchar(100),
Reviews varchar(100)
)

Select * from Customers

Create table OrderHistory
(
OrderId int primary key identity(1, 1),
CustomerId int foreign key references Customers(CustomerId),
OrderedProducts varchar(500),
OrderDate varchar(20),
TotalAmount decimal(10, 2)
)

Select * from OrderHistory