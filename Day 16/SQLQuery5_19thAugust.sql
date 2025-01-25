Create table T1
(
id int primary key identity(1, 1),
a int,
b int
)

Insert into T1(a, b) values
(1, 1),
(1, 2),
(1, 3),
(2, 1),
(1, 2),
(1, 3),
(2, 1),
(2, 2)

Select * from T1

Select a, b, count(*)
AS 'NumberOfTimesPresent'
From T1
Group by a, b
Having count(*)>1

With cte_Duplicates
AS
(
Select a, b, count(*)
AS 'DuplicateRecords'
From T1
Group by a, b
)

Select * from cte_Duplicates Where DuplicateRecords >= 2