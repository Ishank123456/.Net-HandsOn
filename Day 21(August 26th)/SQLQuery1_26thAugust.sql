Create Database WiproDFA_26_08_2024

Use WiproDFA_26_08_2024

Create table [dbo].[Products]
(
	[Id][int] primary key Identity(1, 1) Not Null,
	[Name][varchar](50) Not Null,
	[Description][varchar](250) Not Null,
	[Price][decimal](18, 2) Not Null,
	[Quantity] int
)

Select * from Products