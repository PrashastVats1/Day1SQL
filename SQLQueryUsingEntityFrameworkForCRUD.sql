create database Day8Db
use Day8Db

create table Emps
(Id int primary key,
Fname nvarchar(50) not null,
Lname nvarchar(50) not null,
Designation nvarchar(50),
Salary float,
DOJ date)

insert into Emps values (1,'Ajay','Kumar','Developer',90860.90,'12/25/2021')
insert into Emps values (2,'Vijay','Kiran','Tester',85000.90,'02/15/2023')
insert into Emps values (3,'Nishi','Vats','HR',77000.90,'05/30/2020')
insert into Emps values (9,'Kunal','Garg','Developer',90000.90,'04/08/2022')
select * from Emps
--------------------------------------------------------------------------------------------------------
create proc usp_iEmp
@id int,
@fn nvarchar(50),
@ln nvarchar(50),
@desg nvarchar(50),
@sal float,
@doj date
as
insert into Emps(Id,Fname,Lname,Designation, Salary,DOJ) values (@id,@fn,@ln,@desg,@sal,@doj)

exec usp_iEmp 4,'Saruav','Piyush','Developer',90000.90,'02/25/2022'
select * from Emps
---------------------------------------------------------------------------------------------------------
create proc usp_dEmp
@id int
as
delete from Emps where Id = @id

exec usp_dEmp 3
select * from Emps
----------------------------------------------------------------------------------------------------------
create proc usp_searchEmp
@id int
as
select * from Emps where Id = @id

exec usp_searchEmp 2