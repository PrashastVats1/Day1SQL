create database Day4Db
use Day4Db
--create proc procName
--@parameters
--as
--sql statement
---------------------------------
create table Employee
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50),
Designation nvarchar(50),
Salary float,
DOJ datetime)
insert into Employee values (6,'Sam', 'DCosta','Manager', 99999.99, '10/12/2012')
insert into Employee values (4,'Raj', 'Kumar','Developer', 90000.90, '02/04/2014')
insert into Employee values (3,'Ravi', 'Singh','Tester', 88888.88, '09/12/2013')
insert into Employee values (2,'Priya', 'Garg','Developer', 69696.96, '12/23/2019')
select * from Employee
drop table Employee

create proc usp_sPro
as
select * from Employee

exec usp_sPro
drop proc usp_sPro
----------------------------------------
create proc usp_EmpbyId
@id int
as
select * from Employee where Id = @id

exec usp_EmpbyId 2
exec usp_EmpbyId 6
exec usp_EmpbyId 5
drop proc usp_EmpbyId

--setting default parameters--------------
create proc usp_SEmpbyId
@id int = 1
as
select * from Employee where Id = @id

drop proc usp_SEmpbyId
exec usp_SEmpbyId 2
exec usp_SEmpbyId

alter proc usp_SEmpbyId
@id int = 3
as
select * from Employee where Id = @id

exec usp_SEmpbyId 2
exec usp_SEmpbyId   --takes default as id = 3 when not given any id
-----------------------------------------------------------------------------------
create proc usp_iEmp
@id int,
@fn nvarchar(50),
@ln nvarchar(50),
@desg nvarchar(50),
@sal float,
@doj datetime
as
insert into Employee(Id,Fname,Lname,Salary,Designation,DOJ) values
(@id,@fn,@ln,@sal,@desg,@doj)
if(@@ROWCOUNT>=1)
print 'Record Inserted!!!!!'

exec usp_iEmp 1, 'Renu', 'Gupta', 'HR', 55555.55, '12/12/2020'
--------------------------------------------------------------
--write one stored procedure to update Employee record based on Id
create proc usp_iUpdateRec
@id int,
@fn nvarchar(50),
@ln nvarchar(50),
@desg nvarchar(50),
@sal float,
@doj datetime
as
update Employee set
Fname = @fn, Lname = @ln, Salary = @sal, Designation = @desg, DOJ = @doj where Id = @id
if(@@ROWCOUNT>=1)
print 'Record Updated!!!!!'

exec usp_iUpdateRec 1, 'Ravi', 'Chandan', 'HRD', 66666.66, '06/16/2018'
exec usp_sPro
---------------------------------------------------------
--use proc to delete records
create proc usp_dEmp
@id int
as
delete from Employee where Id = @id
if(@@ROWCOUNT>=1)
print 'Record Deleted!!!!'

exec usp_dEmp 1

exec usp_sPro
--------------------------------
exec sp_server_info
exec sp_tables
exec sp_help
exec sp_helptext 'usp_sPro'
------------------------------------
exec sp_helptext usp_dEmp

alter proc usp_dEmp
@id int
with encryption
as
delete from Employee where Id = @id
if(@@ROWCOUNT>=1)
print 'Record Deleted!!!!'

exec sp_helptext usp_dEmp

alter proc usp_iUpdateRec
@id int,
@fn nvarchar(50),
@ln nvarchar(50),
@desg nvarchar(50),
@sal float,
@doj datetime
with encryption
as
update Employee set
Fname = @fn, Lname = @ln, Salary = @sal, Designation = @desg, DOJ = @doj where Id = @id
if(@@ROWCOUNT>=1)
print 'Record Updated!!!!!'
exec sp_helptext usp_iUpdateRec
------------------------------------------------------------------------------------

insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (11,'Sam','Dicosta',90000,'Manager','12/12/2020')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (12,'Deep','Das',57000,'Tester','12/12/2022')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (13,'Vinay','Kumar',90000,'Manager','12/12/2021')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (14,'Rohit','Gaur',86000,'Developer','12/02/2020')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (15,'Raj','Dixit',76000,'Developer','02/23/2020')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (17,'Sam','Dicosta',90000,'Manager','12/12/2020')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (18,'Deepak','Bansal',57000,'Tester','12/12/2022')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (19,'Zen','S',90000,'Manager','04/10/2018')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (110,'Soni','Sam',86000,'Developer','08/02/2020')
insert into Employee(Id, Fname, Lname, Salary, Designation,DOJ) values (112,'Arsh','Mana',76000,'Developer','12/23/2019')
select * from Employee
select count(Id) as devCount from Employee where Designation = 'Developer'
-------output
create proc sp_DesgCount
@desig nvarchar(50),
@noe int output
as
select @noe = count(Id) from Employee where Designation=@desig

declare @EmpCount int
execute sp_DesgCount 'Tester', @EmpCount output
print @EmpCount

