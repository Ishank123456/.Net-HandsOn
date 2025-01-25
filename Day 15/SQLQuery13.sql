CREATE TABLE Books
(
BookId INT PRIMARY KEY IDENTITY(1, 1),
BookName VARCHAR (50) NOT NULL,
BookPrice INT,
BookCategoryId INT,
BookAuthorId INT
)

CREATE TABLE Categories
(
CategoryId INT PRIMARY KEY,
CategoryName VARCHAR(50) NOT NULL,
)

CREATE TABLE Authors
(
AuthorId INT PRIMARY KEY,
AuthorName VARCHAR(50) NOT NULL,
)


INSERT INTO Categories VALUES 
(1, 'Cat-A'),
(2, 'Cat-B'),
(3, 'Cat-C'),
(7, 'Cat-D'),
(8, 'Cat-E'),
(4, 'Cat-F'),
(10,'Cat-G'),
(12,'Cat-H'),
(6, 'Cat-I')
 
 
INSERT INTO Authors
VALUES 
(1, 'Author-A'),
(2, 'Author-B'),
(3, 'Author-C'),
(10, 'Author-D'),
(12, 'Author-E')
 
INSERT INTO Books 
VALUES 
('Book-A', 100, 1, 2),
('Book-B', 200, 2, 2),
('Book-C', 150, 3, 2),
('Book-D', 100, 3,1),
('Book-E', 200, 3,1),
('Book-F', 150, 4,1),
('Book-G', 100, 5,5),
('Book-H', 200, 5,6),
('Book-I', 150, 7,8)

SELECT * FROM Books
SELECT * FROM Categories
SELECT * FROM Authors

--Left Join b/w Books and Categories
SELECT e1.BookId, e1.BookName, e1.BookPrice, e1.BookCategoryId, e1.BookAuthorId, e2.CategoryId, e2.CategoryName
FROM Books AS e1
LEFT JOIN
Categories as e2
ON
e1.BookCategoryId = e2.CategoryId

--Right Join b/w Books and Categories
SELECT e1.BookId, e1.BookName, e1.BookPrice, e1.BookCategoryId, e1.BookAuthorId, e2.CategoryId, e2.CategoryName
FROM Books AS e1
RIGHT JOIN
Categories as e2
ON
e1.BookCategoryId = e2.CategoryId

--Full Join b/w Books and Categories
SELECT e1.BookId, e1.BookName, e1.BookPrice, e1.BookCategoryId, e1.BookAuthorId, e2.CategoryId, e2.CategoryName
FROM Books AS e1
FULL OUTER JOIN
Categories as e2
ON
e1.BookCategoryId = e2.CategoryId


--Left Join b/w Books and Authors
SELECT e1.BookId, e1.BookName, e1.BookPrice, e1.BookCategoryId, e1.BookAuthorId, e2.AuthorId, e2.AuthorName
FROM Books AS e1
LEFT JOIN
Authors as e2
ON
e1.BookAuthorId = e2.AuthorId

--Right Join b/w Books and Authors
SELECT e1.BookId, e1.BookName, e1.BookPrice, e1.BookCategoryId, e1.BookAuthorId, e2.AuthorId, e2.AuthorName
FROM Books AS e1
RIGHT JOIN
Authors as e2
ON
e1.BookAuthorId = e2.AuthorId

--Full Join b/w Books and Authors
SELECT e1.BookId, e1.BookName, e1.BookPrice, e1.BookCategoryId, e1.BookAuthorId, e2.AuthorId, e2.AuthorName
FROM Books AS e1
FULL OUTER JOIN
Authors as e2
ON
e1.BookAuthorId = e2.AuthorId