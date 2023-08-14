create database joinExDb
use joinExDb

create table Depts
(DId int primary key,
DName nvarchar(50) not null unique)
insert into Depts values (1, 'App-Development'),
(2, 'Web-Development'),
(3, 'HR'),
(4, 'Account'),
(5, 'Agile-Scrum')
select * from Depts order by DId

create table Emps
(Id int primary key,
FName nvarchar(50) not null,
LName nvarchar(50) not null,
Designation nvarchar(50),
Salary float,
DId int)
insert into Emps values (1, 'Ajay', 'Kumar', 'Developer', 87000.92,2)
insert into Emps values (2, 'Vijay', 'Kiran', 'Developer', 87000.90,1)
insert into Emps values (3, 'Nishi', 'Vats', 'Developer', 88000.92,1)
insert into Emps values (9, 'Kunal', 'Garg', 'Developer', 68000.92,2)

insert into Emps(Id, FName, LName, Salary) values (5,'Raj','Kiran', 69000.69)
insert into Emps values (12, 'Deep', 'Goyal', 'Developer', 86000.32,2)
insert into Emps(Id, FName, LName, Designation, Salary) values (13,'Naina','Viz','Manager', 69000.69)
insert into Emps values (15, 'Arsh', 'K.', 'HR', 76000.90,3)

select * from Emps
select * from Depts

--join
--inner join
--outer join : left outer, right outer, full outer
--self join
--cross join

--inner join
--select tableName1.ColumnName, tableName2.ColumnName............... from Table1 join Table2 on Table1.ColumnName=Table2.ColumnName
select* from Emps join Depts on Emps.DId = Depts.DId
--another way to do above
select* from Emps e join Depts d on e.DId = d.DId

select e.FName, d.DName from Emps e join Depts d on e.DId=d.DId

select e.Id, e.FName+' '+e.LName 'Full Name', d.DName 'Department', d.DId, e.Salary, e.Designation
from Emps e join Depts d on e.DId = d.DId

--left outer join
select e.Id, e.FName, e.LName, d.DName 'Department', d.DId, e.Salary, e.Designation
from Emps e left outer join Depts d on e.DId = d.DId

--right outer join
select e.Id, e.FName, e.LName, d.DName 'Department', d.DId, e.Salary, e.Designation
from Emps e right outer join Depts d on e.DId = d.DId

--full outer join
select e.Id, e.FName, e.LName, d.DName 'Department', d.DId, e.Salary, e.Designation
from Emps e full outer join Depts d on e.DId = d.DId

create table Sizes
(SID int primary key,
Size nvarchar(50) not null unique)

create table Colors
(CID int primary key,
Color nvarchar(50) not null unique)

insert into Sizes values(1,'Short'),(2,'Medium'),(3,'Large')
insert into Colors values(1,'Light Blue'),(2,'Green'),(3,'Whitesmoke'),(4,'Pink')

--cross join-> table1 m rows, table2 n rows cross join m*n rows
--Sizes 3, Color 4, cross join 12
select Size, Color from Sizes cross join Colors
insert into Sizes values(4,'Extra Large')
select Size, Color from Sizes cross join Colors

create table Employee
(Id int primary key,
Fname nvarchar(50) not null,
Lname nvarchar(50) not null,
ManagerId int)
insert into Employee(Id, Fname,Lname) values (1, 'Sam','Dcosta')
insert into Employee values (3,'Niraj','Kumar',1)
insert into Employee values (4,'Varun','Sharma',5)
insert into Employee values (6,'Vipin','Singh',1)
insert into Employee values (8,'Gagan','Kumar',2)
insert into Employee values (9,'Gaurav','Kumar',2)
insert into Employee values (10,'Rohit','V',1)
insert into Employee(Id, Fname,Lname) values (5, 'Coffee','Dcosta')
insert into Employee(Id, Fname,Lname) values (2, 'Sam','Bankman-Freid')
select * from Employee

--self join
select e1.Fname+' '+e1.Lname as 'Employee Name', e2.Fname+' '+e2.Lname as 'Manager Name'
from Employee e1 join Employee e2 on e1.ManagerId = e2.Id order by e1.ManagerId

select * from Emps
select sum(Salary) as 'Total Salary' from Emps
select avg(Salary) as 'Average Salary' from Emps
select max(Salary) as 'Maximum Salary' from Emps
select min(Salary) as 'Minimum Salary' from Emps

--string
select UPPER('india')
select LOWER('IndiA')
select left('india',2)
select right('india',3)
select ltrim('           india           ')
select rtrim('           india           ')
select trim('            india           ')

select Upper(FName), upper(LName) from Emps

--Find out initials of Employee from Employee table
--Sam Dcosta-> S. D.
select left(Fname,1)+'.' +' '+ left(Lname,1)+'.' as 'Initials' from Employee

create table Customer
(Id int primary key,
Name nvarchar(50) not null,
ODLimit float not null,
SStartDate date not null,
SEndDate date not null)
insert into Customer values (1,'Sam', 598000,'12/12/2012','12/12/2024')
insert into Customer values (2,'Raj', 678000,'11/11/2011','11/11/2022')
insert into Customer values (3,'Ravi', 888000,'10/10/2010','10/10/2020')

--Date function
select GETDATE()
select DATEPART (day, getdate())
select datepart (MONTH,getdate())
select datepart (year,getdate())
select Datediff (year,'12/12/2000',getdate())
select datepart (month,SStartDate),datepart (year,SStartDate) from Customer
select datepart (month,SEndDate) as 'End Month' ,datepart (year,SEndDate) as 'End Year'from Customer
----------------------------------------------------------------------
--create schemaName.function FunctionName
--(
--parameter
--)
--returns returnType
--as
--begin
--function body
--end
---------------------------------------------------------------------------------------
create function fnFullName
(
@fn nvarchar(50),
@ln nvarchar(50)
)
returns nvarchar(101)
as
begin         --{ -> equivalent
return (select @fn+' '+@ln)
end           --} -> equivalent
select dbo.fnFullName('Raj', 'Kumar') as 'Full Name'
select FName, LName, dbo.fnFullName(fname, lname) as 'Full Employee Name' from Emps
------------------------------------------------------------------------------------------
create function BonusCalc
(@sal float)
returns float
as
begin
return (select @sal*0.15)
end
select dbo.BonusCalc(50000)
select dbo.fnFullName(fname, lname) as 'Full Employee Name',  Salary,dbo.BonusCalc(Salary)as'Bonus' from Emps 

--create schema Schema Name
create table Products
(PID int primary key,
PName nvarchar(50) not null,
PPrice float)

create schema Smasung

create table Smasung.Products
(PID int primary key,
PName nvarchar(50) not null,
PPrice float)
insert into Smasung.Products values (1,'ac',42000)

create schema LG

create table LG.Products
(PID int primary key,
PName nvarchar(50) not null,
PPrice float)
insert into LG.Products values (1,'Washing Machine',23000)
insert into LG.Products values (2,'TV',45000)
insert into LG.Products values (3,'Mobile',34000)

create function LG.fnTax
(@price float)
returns float
as
begin
declare @tax float;
if(@price>=25000)
begin
select @tax = @price*0.18
end
else
begin
select @tax = @price*0.10
end
return @tax
end
select LG.fnTax(42000) as 'Tax'

select PId, PName, PPrice, LG.fnTax(PPrice) as 'GST' from LG.Products
select PId, PName, PPrice, LG.fnTax(PPrice) as 'GST' from Smasung.Products
-------------------------------------------------------------------------------
drop table Products

create table Products
(PID int primary key,
PName nvarchar(50) not null,
PPrice float,
PCategory nvarchar(50) not null check(PCategory in ('Clothing','Grooming', 'Electronics', 'Other')))
insert into Products values (1, 'Face Wash', 230, 'Grooming')
insert into Products values (2, 'TV', 45000, 'Electronics')
insert into Products values (3, 'Mobile', 34000, 'Electronics')
insert into Products values (4, 'Face Cream', 250, 'Grooming')
select * from Products
select sum(PPrice) as 'Total Products Value' from Products
select sum(PPrice) as 'Sub Total', PCategory from Products group by PCategory
--------------------------------------------------------------------------------------------------------------------
create table Expenses
(ExpId int primary key identity,
ExpAmount float,
ExpCat nvarchar(50) not null check(ExpCat in ('Stationary', 'Electronics', 'Others')),
ExpDate date default getdate())

insert into Expenses values (1200.50, 'Stationary','12/12/2012')
insert into Expenses(ExpAmount, ExpCat) values (72000.50,'Electronics')
insert into Expenses values (52400.50, 'ELectronics','12/12/2012')
insert into Expenses values (2300.50, 'Stationary','12/12/2012')
insert into Expenses values (1500.50, 'Stationary','12/12/2012')
insert into Expenses values (1800.50, 'Others','12/12/2012')
insert into Expenses(ExpAmount, ExpCat) values (1350.50,'Stationary')
insert into Expenses values (1400.50, 'Others','12/12/2012')
select * from Expenses
select sum(ExpAmount) as 'Total Exp'from Expenses
select sum(ExpAmount) as 'Category Wise Total', ExpCat from Expenses group by ExpCat

select sum(ExpAmount) as 'Category Wise Total', ExpCat from Expenses group by ExpCat

select sum(ExpAmount) as 'Category Wise Total', ExpCat from Expenses
where ExpAmount>=(select avg(ExpAmount) from Expenses)
group by ExpCat having ExpCat='Electronics'