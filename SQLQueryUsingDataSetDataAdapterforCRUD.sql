create database Day7DB
use Day7DB

create table Customer
(Id int primary key,
Name nvarchar(50) not null,
ODLimit float not null,
SStartDate Date not null,
SEndDate Date not null)
insert into Customer values (1,'Sam', 598000,'12/15/2022','12/23/2024')
insert into Customer values (2,'Ravi', 678000,'02/20/2021','12/13/2025')
insert into Customer values (3,'Raj', 88000,'01/31/2023','02/29/2024')
select * from Customer