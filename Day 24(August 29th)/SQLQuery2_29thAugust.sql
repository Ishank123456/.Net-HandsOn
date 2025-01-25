--drop table Country
CREATE TABLE [dbo].[Country](
	[CountryId] [int]  IDENTITY(1,1) NOT NULL Primary Key,
	[CountryName] [varchar](50) NOT NULL,
)

--drop table State
CREATE TABLE [dbo].[State](
	[StateId] [int]  IDENTITY(1,1) NOT NULL Primary Key,
	[StateName] [varchar](50) NOT NULL,
	[CountryId] [int] FOREIGN KEY REFERENCES [dbo].[Country](CountryId)
)
 
Select * from Country
Select * from State