create database CustDb
use CustDb

create table Customer
(CustomerId int primary key,
CustomerName nvarchar(50),
CustomerCity nvarchar(50),
CustomerODLimit float)

insert into Customer values (1,'Sam','Goa',98000.50)
insert into Customer values (2,'Raj','Pune',76000.55)
insert into Customer values (3,'Mahi','Delhi',97000.75)
insert into Customer values (4,'Gagan','Bangalore',75000.75)
insert into Customer values (5,'Shilpa','Hyderabad',85000.45)
insert into Customer values (11,'Shruti','Ranchi',84000.20)

select * from Customer

insert into Customer values (12,'Sam','Goa',98000.50)
insert into Customer values (21,'Raj','Pune',76000.55)
insert into Customer values (13,'Mahi','Delhi',97000.75)
insert into Customer values (14,'Gagan','Bangalore',75000.75)
insert into Customer values (15,'Shilpa','Hyderabad',85000.45)
insert into Customer values (18,'Shruti','Ranchi',84000.20)