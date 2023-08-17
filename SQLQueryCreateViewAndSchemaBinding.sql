create database Day5Db
use Day5Db
create table Emp
(Id int,
Name nvarchar(50),
Salary float)
insert into Emp values (2,'Sam',98000.50)
insert into Emp values (12,'Ravi',88000.50)
insert into Emp values (5,'Raj',69000.50)
insert into Emp values (6,'Deep',96000.50)
select * from Emp
select * from Emp where Id = 5
drop table Emp
----------------------------------------------------
--CREATE CLUSTERED INDEX indexName
--ON <tableName>(column)
-----------------------------------------------------
create clustered index Emp_Id_Index on Emp(Id)
select * from Emp where Name ='Deep'

drop table Emp
create table Emp
(Id int primary key,
Name nvarchar(50),
Salary float)
create clustered index Emp_Id_Index on Emp(Id)
insert into Emp values (2,'Sam',98000.50)
insert into Emp values (12,'Ravi',88000.50)
insert into Emp values (5,'Raj',69000.50)
insert into Emp values (6,'Deep',96000.50)
select * from Emp
----------------------------------------------
create index Emp_Sal_Index on Emp(Salary)
------------------------------------------------
--CREATE NONCLUSTERED INDEX IX_PurchaseOrderDetail_RejectedQty
--On Purchasing.PurchaseOrderDetail
--(RejectedQty DESC, ProductID ASC, DueDate, OrderQty)
----------------------------------------------------
create table Customers
(CID int primary key,
CName nvarchar(50) not null,
CODLimit float)
insert into Customers values (1,'Raj',89000.50)
insert into Customers values (2,'Deep',60000.50)
insert into Customers values (3,'Amit',76000.50)
insert into Customers values (4,'Vinay',82000.50)
insert into Customers values (5,'Ritesh',45000.50)
insert into Customers values (7,'Deep',75000.50)
select * from Customers

create view cust_view
as
select CName, CODLimit from Customers

select * from cust_view
insert into Customers values (8,'Deep',78000.50)
delete from cust_view where CName = 'Deep'

alter view cust_view
as
select CODLimit from Customers

create view cust_view2
as
select CName, CId from Customers

insert into cust_view2 values ('Nitish', 15)
select * from cust_view2

alter table Customers drop column CName

select * from cust_view
select * from cust_view2
--Level 16, State 1, Procedure cust_view2, Line 3 [Batch Start Line 72]      Invalid column name 'CName'.
--Level 16, State 1, Line 73       Could not use view or function 'cust_view2' because of binding errors.

create schema bank
create table bank.Customers
(CID int primary key,
CName nvarchar(50) not null,
CODLimit float)
insert into bank.Customers values (1,'Raj',89000.50)
insert into bank.Customers values (2,'Deep',60000.50)
insert into bank.Customers values (3,'Amit',76000.50)
insert into bank.Customers values (4,'Vinay',82000.50)
insert into bank.Customers values (5,'Ritesh',45000.50)
insert into bank.Customers values (7,'Deep',75000.50)

create view bank.cust_view2
with schemabinding
as
select CName, CId from bank.Customers

select * from bank.cust_view2

alter table bank.Customers drop column CName
--Level 16, State 1, Line 96     The object 'cust_view2' is dependent on column 'CName'.
--Level 16, State 9, Line 96     ALTER TABLE DROP COLUMN CName failed because one or more objects access this column.

use joinExDb

create view viewEmpDept
as
select e.Id, e.Fname+' '+e.Lname 'Full Name', d.DName 'Department', d.DId, e.Salary, e.Designation
from Emps e join Depts d on e.DId = d.DId
select * from Emps
select * from Depts
select * from viewEmpDept where Department='Web-Development'
select * from viewEmpDept where Salary>=86000
select * from viewEmpDept where Salary<=86000