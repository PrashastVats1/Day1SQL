create database ProductInventoryDb
use ProductInventoryDb
create table Products
(ProductId int primary key,
ProductName nvarchar(100) not null,
Price float not null,
Quantity int not null,
MfDate date,
ExpDate date)
insert into Products(ProductId, ProductName, Price, Quantity, MfDate) values 
(1, 'PlayStation 5', 10000.50, 50, '01/08/2023'),
(2, 'HP Pavillion', 82000.75, 75, '05/08/2018'),
(4, 'Nothing Phone 2', 51548.25, 60, '06/05/2023')
insert into Products values (5, 'RockRider ST 40', 18333.75, 90, '08/10/2023','09/11/2030')
insert into Products values (3, 'Copper Bottle', 800.25, 30, '07/24/2023','12/21/2026')
insert into Products values (6, 'Buldak Cheese Ramen', 110, 40, '06/24/2022','12/27/2024')
insert into Products values (7, 'Dabur Honey', 150.25, 52, '06/18/2023','07/14/2024')
insert into Products values (8, 'Protein Powder', 1800.25, 47, '07/14/2023','12/15/2024')
select * from Products