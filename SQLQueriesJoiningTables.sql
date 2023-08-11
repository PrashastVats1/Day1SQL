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