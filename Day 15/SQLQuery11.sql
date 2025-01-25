Create Database Wipro_16_08_2024

Use Wipro_16_08_2024

Create table Employee
(
EmpId int primary key identity(1, 1),
EmpName varchar(50),
EmpAge int,
EmpGender varchar(10),
EmpQualification varchar(50),
EmpSalary int,
EmpCity varchar(20),
EmpCountry varchar(20)
)

Insert into Employee values('Rahul', 28, 'Male', 'B.Tech Graduate', 70000, 'Mumbai', 'India')
Insert into Employee values('Somnath', 32, 'Male', 'M.Tech Graduate', 80000, 'Hyderabad', 'India')
Insert into Employee values('Pragati', 26, 'Female', 'B.Tech Graduate', 50000, 'Banglore', 'India')
Insert into Employee values('Davis', 29, 'Male', 'MBA Graduate', 100000, 'New York', 'USA')
Insert into Employee values('Vinay', 25, 'Male', 'B.A. Hons. Graduate', 15000, 'Delhi', 'India')
Insert into Employee values('Koushik', 56, 'Male', 'Phd Doctorate', 95000, 'Noida', 'India')
Insert into Employee values('Nisha', 24, 'Female', 'B.Tech Graduate', 36000, 'Chennai', 'India')
Insert into Employee values('Arka', 23, 'Male', 'Pharma Graduate', 20000, 'Toronto', 'Canada')
Insert into Employee values('Sohom', 28, 'Male', 'MBA Graduate', 65500, 'Banglore', 'India')
Insert into Employee values('Preeti', 35, 'Female', 'M.Tech Graduate', 76700, 'Kolkata', 'India')
Insert into Employee values('Pritom', 27, 'Male', 'B.Tech Graduate', 72000, 'Mumbai', 'India')
Insert into Employee values('Sayantan', 25, 'Male', 'BBA Graduate', 29000, 'Gurgaon', 'India')
Insert into Employee values('Manbir', 28, 'Male', 'B.Tech Graduate', 60000, 'Pune', 'India')
Insert into Employee values('Anik', 30, 'Female', 'M.Tech Graduate', 90000, 'Hyderabad', 'India')
Insert into Employee values('Rajdeep', 24, 'Male', 'B.Tech Graduate', 20000, 'Banglore', 'India')
Insert into Employee values('Ayesha', 52, 'Female', 'Phd Doctorate', 125000, 'Delhi', 'India')
Insert into Employee values('Pratap', 29, 'Male', 'MBA Graduate', 150000, 'California', 'USA')
Insert into Employee values('Akash', 26, 'Male', 'B.Tech Graduate', 65000, 'Hyderabad', 'India')
Insert into Employee values('Vivek', 27, 'Male', 'B.A.Hons. Graduate', 30000, 'Delhi', 'India')
Insert into Employee values('Deblina', 22, 'Female', 'B.Tech Graduate', 35000, 'Noida', 'India')
Insert into Employee values('Subham', 31, 'Male', 'M.Tech Graduate', 80000, 'Kolkata', 'India')

Select * from Employee

Select * from Employee Where EmpAge < 25 or EmpAge > 50
Select * from Employee Where EmpAge between 20 and 40

Select * from Employee Where EmpCountry = 'India' 
and EmpCity in('Hyderabad', 'Noida') or EmpCity = 'Banglore'

Select * from Employee Order by EmpName asc
Select * from Employee Order by EmpAge desc

Select * from Employee Where EmpSalary = 20000
Select * from Employee Where EmpSalary > 50000
Select * from Employee Where EmpSalary between 20000 and 50000