CREATE TABLE ProductQty
(
Id INT PRIMARY KEY IDENTITY(1, 1),
Region VARCHAR(50),
Product VARCHAR(50),
Year INT,
Quantity INT,
Price INT
)

INSERT INTO ProductQty VALUES('East', 'Computer', 2020, 130, 50000)
INSERT INTO ProductQty VALUES('South', 'Computer', 2020, 450, 35000)
INSERT INTO ProductQty VALUES('North', 'Computer', 2020, 250, 40000)
INSERT INTO ProductQty VALUES('East', 'Hard Disk', 2020, 190, 5500)
INSERT INTO ProductQty VALUES('West', 'Computer', 2021, 250, 45000)
INSERT INTO ProductQty VALUES('South', 'Hard Disk', 2021, 550, 4400)
INSERT INTO ProductQty VALUES('West', 'Hard Disk', 2021, 650, 7500)
INSERT INTO ProductQty VALUES('East', 'Pen Drive', 2021, 120, 800)
INSERT INTO ProductQty VALUES('North', 'Mouse', 2029, 160, 1500)
INSERT INTO ProductQty VALUES('South', 'Pen Drive', 2019, 270, 750)
INSERT INTO ProductQty VALUES('East', 'Mouse', 2019, 2000, 1200)
INSERT INTO ProductQty VALUES('West', 'Pen Drive', 2019, 190, 650)

SELECT * FROM ProductQty

--FUNCTIONS
SELECT MIN(Quantity) AS 'Minimum Quantity' FROM ProductQty
SELECT MAX(Quantity) AS 'Maximum Quantity' FROM ProductQty

SELECT Id, Product, Quantity, Price FROM ProductQty
WHERE Quantity = (SELECT MIN(Quantity) AS 'Minimum Quantity' FROM ProductQty)

SELECT Id, Product, Quantity, Price FROM ProductQty
WHERE Quantity = (SELECT MAX(Quantity) AS 'Maximum Quantity' FROM ProductQty)

--GROUP BY Clause
SELECT Product, SUM(Price) 'Price' FROM ProductQty
GROUP BY Product

SELECT Region, Product, SUM(Price) 'Price' FROM ProductQty
GROUP BY Region, Product
ORDER BY Region

SELECT Region, Product, SUM(Quantity) AS 'Quantity', SUM(Price) AS 'Price' FROM ProductQty
WHERE Region = 'East'
GROUP BY Region, Product
ORDER BY Region, Product

SELECT Product, MAX(Quantity * Price) AS 'Highest Value Price' FROM ProductQty
GROUP BY Product

--HAVING Clause
SELECT Product, MAX(Quantity) AS 'Maximum Quantity' FROM ProductQty
GROUP BY Product
HAVING MAX(Quantity) > 300