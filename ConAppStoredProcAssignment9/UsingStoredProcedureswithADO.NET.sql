create database OrderDb
use OrderDb

create table Customers
(CustomerId int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
TotalSpending decimal)

create table Orders
(OrderId int identity(101,1)primary key,
CustomerId int foreign key references Customers(CustomerId),
OrderDate datetime,
TotalAmount float)

insert into Customers(CustomerId,FirstName,LastName) values
(1, 'John', 'Wick'),
(2, 'Janet', 'VanDyne'),
(3, 'Nischay', 'Khatri'),
(4, 'Dhruv', 'Patteritaza'),
(5, 'Neelansh', 'Yadav')
drop table Orders
insert into Orders values
(1, '08/01/2022 09:30:00 AM', 1000.00),
(2, '08/02/2023 02:45:00 PM', 1500.50),
(1, '08/03/2021 11:20:00 AM', 750.20),
(3, '08/04/2020 03:15:00 PM', 2000.75),
(4, '08/05/2022 08:00:00 AM', 5150.00),
(5, '08/06/2019 01:10:00 PM', 3780.00),
(2, '08/07/2020 05:30:00 PM', 8000.00),
(3, '08/08/2017 10:45:00 AM', 1200.00),
(1, '08/09/2021 12:40:00 PM', 9078.50),
(4, '08/10/2022 09:00:00 AM', 1841.25)
select * from Customers
select * from Orders

create proc usp_PlaceOrder
@CID int,
@TA float
as
begin
insert into Orders(CustomerId, OrderDate, TotalAmount)
values (@CID, getdate(), @TA)
update Customers
set TotalSpending = isnull(TotalSpending,0)+@TA
where CustomerId = @CID
end

exec usp_PlaceOrder @CID = 1, @TA = 5000.78;
