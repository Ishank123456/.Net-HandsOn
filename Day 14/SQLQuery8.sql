Create table Employee2
(
EmpId int primary key identity(1, 1),
EmpName varchar(50),
EmpContactName varchar(50),
EmpAddress varchar(50),
EmpCity varchar(50),
EmpPostalCode varchar(50),
EmpCountry varchar(50),
EmpGender varchar(50),
EmpEmail varchar(50),
)

Select * from Employee2

Select * from Employee2 Where EmpName like '%s%'
Select * from Employee2 Where EmpName like 's%'
Select * from Employee2 Where EmpName like '%s'

Select Distinct EmpName, EmpCity from Employee2

Select * from Employee2 Where EmpCountry = 'India'
Select * from Employee2 Where EmpCountry = 'India' or EmpCountry = 'USA'

Select * from Employee2 Where EmpCountry in('India', 'USA')
Select * from Employee2 Where EmpCountry in('India', 'USA', 'Canada')
and EmpGender = 'Male'
Select * from Employee2 Where EmpCountry = 'India'
and EmpCity in('Banglore', 'Noida')

Select * from Employee2 Order by EmpName asc
Select * from Employee2 Order by EmpName desc

Update Employee2
Set
EmpCity = 'Toronto', EmpPostalCode = '66777', EmpEmail = 'joe231@gmail.com'
Where EmpId = 6

