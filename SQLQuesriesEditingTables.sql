--primary key is not null
CREATE DATABASE Phase2DB
USE Phase2DB
--unique: not duplicate, you can write null in unique column but only once
--we can write multiple uniques per table
CREATE TABLE Emps
(Id INT PRIMARY KEY,
Fname NVARCHAR(50) NOT NULL,
Lname NVARCHAR(50) NOT NULL,
Mobile VARCHAR(10) UNIQUE,
Email NVARCHAR(100) UNIQUE
)
INSERT INTO Emps VALUES (1, 'Sam', 'DCosta', '9876543210', 'sd@gmail.com')
INSERT INTO Emps(Id, Fname, Lname, Mobile, Email) VALUES (2, 'Ravi', 'Kumar', '9874561230', 'rk@gmail.com')
INSERT INTO Emps(Id, Fname, Lname, Mobile, Email) VALUES (3, 'Nitin', 'Kumar', '9874563210', 'nk@gmail.com')
INSERT INTO Emps(Id, Fname, Lname, Mobile, Email) VALUES (4, 'Sachin', 'Kumar','' , 'sk@gmail.com')
INSERT INTO Emps(Id, Fname, Lname, Mobile, Email) VALUES (5, 'Manish', 'Kumar', '8874561230', '')

INSERT INTO Emps(Id, Fname, Lname, Mobile, Email) VALUES (6, 'Manii', 'Kumar','' , 'mk@gmail.com')
--Violation of UNIQUE KEY constraint 'UQ__Emps__6FAE078227D2ED2F'. Cannot insert duplicate key in object 'dbo.Emps'. The duplicate key value is ().

INSERT INTO Emps(Id, Fname, Lname, Mobile, Email) VALUES (7, 'Honey', 'Kumar', '9874561230', '')
--Violation of UNIQUE KEY constraint 'UQ__Emps__A9D10534EFCAC386'. Cannot insert duplicate key in object 'dbo.Emps'. The duplicate key value is ().

SELECT * FROM Emps
---------------------------------
--check
DROP TABLE Emps

CREATE TABLE Emps
(Id INT PRIMARY KEY,
Fname NVARCHAR(50) NOT NULL,
Lname NVARCHAR(50) NOT NULL,
Salary FLOAT CHECK (Salary>=10000)
)
INSERT INTO Emps VALUES (1, 'Sam', 'DCosta',60000)
INSERT INTO Emps VALUES (2, 'Sam', 'DCosta',50000)

INSERT INTO Emps VALUES (3, 'Sam', 'DCosta',6000)
--The INSERT statement conflicted with the CHECK constraint "CK__Emps__Salary__2A6B46EF".
--The conflict occurred in database "master", table "dbo.Emps", column 'Salary'.

--pattern check using check
CREATE TABLE Employee
(Id INT PRIMARY KEY,
Fname NVARCHAR(50) NOT NULL,
Lname NVARCHAR(50) NOT NULL,
Mobile VARCHAR(10) NOT NULL UNIQUE CHECK (Mobile LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
INSERT INTO Employee VALUES (1, 'Sam', 'DCosta','9876543210')

INSERT INTO Employee VALUES (2, 'Ravi', 'Kumar','987654321')
--The INSERT statement conflicted with the CHECK constraint "CK__Employee__Mobile__320C68B7". 
--The conflict occurred in database "master", table "dbo.Employee", column 'Mobile'.
DROP TABLE Employee

CREATE TABLE Employee
(Id INT PRIMARY KEY,
Fname NVARCHAR(50) NOT NULL,
Lname NVARCHAR(50) NOT NULL,
Mobile VARCHAR(10) NOT NULL UNIQUE CHECK (Mobile LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
City NVARCHAR(50) DEFAULT 'Delhi'
)
INSERT INTO Employee(Id, Fname, Lname, Mobile) VALUES (1, 'Nitin', 'Kumar', '9874563210')
INSERT INTO Employee(Id, Fname, Lname, Mobile, City) VALUES (2, 'Mitin', 'Kumar', '9874563211', 'Noida')
SELECT * FROM Employee

--identity
--identity(seed, increment)
--default seed =1, increment = 1
CREATE TABLE Customer
(CId INT IDENTITY,
CName NVARCHAR(50) NOT NULL,
CCity NVARCHAR(50) NOT NULL
)
INSERT INTO Customer VALUES ('Raj', 'Delhi')
INSERT INTO Customer VALUES ('Ravi', 'Noida')
INSERT INTO Customer VALUES ('Mithun', 'Hyderabad')
SELECT * FROM Customer
DROP TABLE Customer

CREATE TABLE Customer
(CId INT IDENTITY(5,2),
CName NVARCHAR(50) NOT NULL,
CCity NVARCHAR(50) NOT NULL
)
INSERT INTO Customer VALUES ('Raj', 'Delhi')
INSERT INTO Customer VALUES ('Ravi', 'Noida')
INSERT INTO Customer VALUES ('Mithun', 'Hyderabad')
SELECT * FROM Customer
DROP TABLE Customer

CREATE TABLE Customer
(CId INT IDENTITY(1000,1),
CName NVARCHAR(50) NOT NULL,
CCity NVARCHAR(50) NOT NULL
)
INSERT INTO Customer VALUES ('Raj', 'Delhi')
INSERT INTO Customer VALUES ('Ravi', 'Noida')
INSERT INTO Customer VALUES ('Mithun', 'Hyderabad')
SELECT * FROM Customer

--------------reference key------------
CREATE TABLE Student
(SId INT PRIMARY KEY,
SName NVARCHAR(50) NOT NULL,
SAge INT
)
INSERT INTO Student VALUES (1,'Ravi', 12)
INSERT INTO Student VALUES (2,'Kishan', 13)
INSERT INTO Student VALUES (3,'Shyam', 11)
SELECT * FROM Student

CREATE TABLE Exam
(ExamId INT PRIMARY KEY,
SId INT FOREIGN KEY REFERENCES Student,
Marks INT NOT NULL CHECK(Marks<=500)
)
INSERT INTO Exam VALUES (1,1,499)

INSERT INTO Exam VALUES (2,4,499)
--The INSERT statement conflicted with the FOREIGN KEY constraint "FK__Exam__SId__3E723F9C". 
--The conflict occurred in database "master", table "dbo.Student", column 'SId'.

CREATE TABLE Category
(CId INT PRIMARY KEY,
CName NVARCHAR(50) UNIQUE)
INSERT INTO Category VALUES (1, 'Clothing')
INSERT INTO Category VALUES (2, 'Electronics')
INSERT INTO Category VALUES (3, 'Grooming')

CREATE TABLE Product
(PId INT PRIMARY KEY IDENTITY,
PName NVARCHAR(50) NOT NULL,
Category INT FOREIGN KEY REFERENCES Category)
INSERT INTO Product VALUES ('T-Shirt', 1)
INSERT INTO Product VALUES ('Shirt', 1)
INSERT INTO Product VALUES ('Face Wash', 3)
INSERT INTO Product VALUES ('Face Cream', 3)

INSERT INTO Product VALUES ('Bag', 4)
--The INSERT statement conflicted with the FOREIGN KEY constraint "FK__Product__Categor__46136164".
--The conflict occurred in database "master", table "dbo.Category", column 'CId'.
SELECT * FROM Category
SELECT * FROM Product

SELECT * FROM Product, Category WHERE Category.CId = Product.Category

SELECT p.PID, p.PName, c.CName FROM Product AS p, Category AS c WHERE c.CId = p.Category
