Create database WiproAugust
use WiproAugust

Create table Customer
(
CustomerId int,
CustomerName varchar(50),
CustomerGender varchar(50),
CustomerCountry varchar(50)
)

Select * from Customer
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(1,'Gundmi, Arun A','Male','India')

Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(2,'Palepu, Tirupathirao','Male','India')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(3,'T, Divya','Female','India')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(4,'Halagunaki, Pramod','Male','USA')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(5,'Joshi, Amar','Male','USA')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(6,'Dayakar Reddy, Vajrala','Male','UK')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(7,'R, Madhavi','Female','Germany')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(8,'Sinha, Manish P','Male','Canada')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(9,'Sumitha Siriya','Female','Canada')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(10,'Agarwal Saurabh','Male','India')
 
Insert into Customer(CustomerId, CustomerName, CustomerGender, CustomerCountry) values
(11,'Kumar, Pawan','Male','USA')


Select * from Customer Where CustomerCountry = 'India'
Select * from Customer Where CustomerCountry = 'India' and CustomerGender = 'Male'
Select * from Customer Where CustomerName like 'D%'
Select * from Customer Where CustomerName like '%D%'

Select * from Customer Where CustomerGender = 'Female' or CustomerCountry = 'Canada'

Select * from Customer order by CustomerName asc
Select * from Customer order by CustomerName desc