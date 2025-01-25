create table Supplier
(
Supplier_Id int,
Supplier_Name varchar(20),
Supplier_City varchar(20),
Supplier_State varchar(20)
)

Insert into Supplier values(100, 'Microsoft', 'Redmond', 'Washington')
Insert into Supplier values(200, 'Google', 'Mountain View', 'California')
Insert into Supplier values(300, 'Oracle', 'Rewood City', 'California')
Insert into Supplier values(400, 'Kimbarly-Clark', 'Irving', 'Texas')
Insert into Supplier values(500, 'Tyson Foods', 'Springdale', 'Arkansas')
Insert into Supplier values(600, 'SC Johnson', 'Racine', 'Wisconsin')
Insert into Supplier values(700, 'Dole Food Company', 'Westlake Village', 'California')
Insert into Supplier values(800, 'Flowers Foods', 'Thomasville', 'Georgia')
Insert into Supplier values(900, 'Electronic Arts', 'Redwood City', 'California')

Select * from Supplier

Select * from Supplier Where Supplier_State = 'California' And Supplier_Name = 'Google'
Select * from Supplier Where Supplier_State = 'Texas' Or Supplier_Name = 'Microsoft'

Select * from Supplier Where Supplier_Name like '%s%'
Select * from Supplier Where Supplier_Name like 's%'
Select * from Supplier Where Supplier_Name like '%s'

Select Distinct Supplier_Name, Supplier_City from Supplier

Select * from Supplier Order by Supplier_Name asc
Select * from Supplier Order by Supplier_Name desc

Update Supplier
Set
Supplier_City = 'Austin', Supplier_State = 'Texas'
Where Supplier_Id = 300