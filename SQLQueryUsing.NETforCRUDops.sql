create database EmpsDb
use EmpsDb
create table Emps
(Id int primary key,
Fname nvarchar(50) not null,
Lname nvarchar(50) not null,
Designation nvarchar(50),
Salary float)
insert into Emps values (1,'Ajay','Kumar','Developer',97000.50)
insert into Emps values (2,'Vijay','Kiran','Developer',99000.50)
insert into Emps values (3,'NIshi','Vats','Developer',94000.50)
insert into Emps values (9,'Kunal','Garg','Developer',87000.50)
insert into Emps(Id,Fname,Lname,Salary) values (5,'Raj','Kiran',88000.50)
insert into Emps values (12,'Deep','Goyal','Developer',86000.50)
insert into Emps(Id, Fname, Lname, Designation, Salary) values (13,'Naina','Viz','Manager',67000.50)
insert into Emps values (15,'Arsh','K','HR',76000.50)
delete from Emps where Id>=20
select * from Emps