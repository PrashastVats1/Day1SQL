create database Assignment8Db
use Assignment8Db

create table Employees
(EmployeeId int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
BirthDate date,
Salary decimal(18,2))

create table Products
(ProductId int primary key,
ProductName nvarchar(100),
Description nvarchar(100),
Price money,
ReleaseDate datetime)

create table Orders
(OrderId int primary key,
OrderDate datetime,
Quantity smallint,
Discount float,
IsShipped bit)

insert into Employees values
(1, 'Prakash', 'Jha', '05/23/1992', 200000.75),
(2, 'Damien', 'Fox', '04/19/2001', 60000.50),
(3, 'Michael', 'Jackson', '10/11/1988', 75000.25),
(4, 'Ishan', 'Kumar', '08/22/1995', 55000.75),
(5, 'Mahesh', 'Dalle', '12/31/1989', 80000.00)

insert into Products values
(1, 'HP Pavillion', 'High-performance laptop with 1TB storage', 83456.50, '08/22/2018'),
(2, 'Nothing 2', 'Latest model with better glyph interface', 51458.78, '09/07/2023'),
(3, 'Boat Headset', 'Noise-canceling wired headphones', 900.25, '05/01/2020'),
(4, 'Razor Mouse', 'Wireless RGB mouse', 600.45, '12/12/2022'),
(5, 'Sony Bravia', '27-inch 4K monitor', 11456.55, '09/19/2019')

insert into Orders values
(1, '05/01/2018 09:30:00', 500, 0.25, 1),
(2, '05/02/2023 14:15:00', 600, 0.15, 0),
(3, '03/18/2020 11:45:00', 750, 0.18, 0),
(4, '06/06/2022 17:20:00', 412, 0.10, 1),
(5, '08/28/2018 10:00:00', 789, 0.15, 1)

select * from Employees
select * from Products
select * from Orders
--EmployeeId: int32, FirstName: string, LastName: string, BirthDate: DateTime, Salary: Decimal
--ProductId: int32, ProductName: string, Description: string, Price: Decimal, ReleaseDate: DateTime
--OrderId: int32, OrderDate: DateTime, Quantity: int16, Discount: Double, IsShipped: Boolean