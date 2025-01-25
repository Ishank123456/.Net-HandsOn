Create table Student
(
StudentId int,
StudentName varchar(50),
SectionName varchar(10),
StudentMarks int
)

--Drop table student

Insert into Student values(1,'Santosh','A',401)
Insert into Student values(1,'Mondal','A',499)
Insert into Student values(2,'Vivek','A',450)
Insert into Student values(2,'Shubham','B',350)
Insert into Student values(2,'Keerthrana','B',370)
Insert into Student values(3,'Laxmi','A',478)
Insert into Student values(3,'Vishawajeet','C',490)
Insert into Student values(4,'Monika','C',401)
Insert into Student values(4,'Jai Shankar','D',500)
Insert into Student values(4,'ShreeVidhya','D',480)
Insert into Student values(4,'UdayShree','A',390)
Insert into Student values(4,'IshanK','A',400)
Insert into Student values(5,'Nishant','B',378)
Insert into Student values(5,'Arvind','B',410)
Insert into Student values(5,'Barsha','C',409)
Insert into Student values(6,'Kamalesh','D',480)

Select * from Student

--Order by with ROW_NUMBER() Func.
Select *, row_number() over(order by StudentMarks desc) as 'RankNumber' from Student

--Partition by with ROW_NUMBER() Func.
Select *,
ROW_NUMBER() over(partition by SectionName order by StudentMarks desc)
as RankNumber from Student

--CTE---Common Table Expression
With cte_twoTopRankers
AS
(
Select *,
ROW_NUMBER() over(partition by SectionName order by StudentMarks desc)
as RankNumber from Student
)

Select * from cte_twoTopRankers Where RankNumber <= 2