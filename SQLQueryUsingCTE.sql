use Day4Db

create schema Sales
create table Sales.Employees
(ID int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
Department nvarchar(50) not null check (Department in('Sales','HR','IT', 'Other')))

insert into Sales.Employees values (1, 'Sam','DCosta', 'Sales')
insert into Sales.Employees values (2, 'Arsh','Maan', 'HR')
insert into Sales.Employees values (3, 'Ruhee','Nazir', 'IT')
insert into Sales.Employees values (4, 'Danish','Wani', 'Sales')
insert into Sales.Employees values (9, 'Sam','Nigam', 'Sales')
insert into Sales.Employees values (10, 'Jeevan','Dixit', 'HR')
insert into Sales.Employees values (11, 'Deep','Das', 'IT')
insert into Sales.Employees values (13, 'Gagan','Kapoor', 'Sales')
select * from Sales.Employees
--CTE Example
with sales_emp
as
(select * from Sales.Employees where Department = 'Sales')
select count(*) as 'Number of Employees in Sales' from sales_emp
-----------------------------------------------------------------------------------
--select
with myemp(Emp_Id,Emp_Name,Emp_Dept)
as
(select ID, FirstName, Department from Sales.Employees)
select Emp_Id, Emp_Name from myemp
-----------------------------------------------------------------------------------
--insert
with myemp(Emp_Id,Emp_Name,Emp_Dept)
as
(select ID, FirstName, Department from Sales.Employees)
insert myemp(Emp_Id, Emp_Name, Emp_Dept) values (18,'Deepak', 'Sales')
------------------------------------------------------------------------------------
--delete
with myemp(Emp_Id,Emp_Name,Emp_Dept)
as
(select ID, FirstName, Department from Sales.Employees)
delete myemp where Emp_Id = 18
-------------------------------------------------------------------------------------
--update
with myemp(Emp_Id,Emp_Name,Emp_Dept)
as
(select ID, FirstName, Department from Sales.Employees)
update myemp set Emp_Name='Raj' where Emp_Id =4

select * from Sales.Employees

create table Employees
(ID int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
ManagerID int)
insert into Employees values (1,'Sam','DCosta', null)
insert into Employees values (2,'Arsh','Maan', 1)
insert into Employees values (3,'Ruhee','Nazir', null)
insert into Employees values (4,'Danish','Wani', 1)
insert into Employees values (6,'Aditi','Goyal', 3)
insert into Employees values (7,'Rohit','Sharma', 1)
insert into Employees values (9,'Viz','G', 3)
select * from Employees
--CTE Recursive
with DirectReports
as
(select ID, FirstName, LastName
from Employees
where ManagerID = 1
union all
select e.ID, e.FirstName, e.LastName
from Employees e
join DirectReports d on e.ManagerID = d.ID)
select * from DirectReports