create database TriggersDB
use TriggersDB

--syntax to create a DML trigger
--CREATE TRIGGER [schema name.]trigger_name
--ON[schema_name.]table_name[WITH ENCRYPTION]
--{after INSERT} AS
--[IF UPDATE (column_name)...]
--[{AND | OR} UPDATE (column_name)...]
--<sql_statements>
--Magic Tables: inserted, deleted
create table Emps
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50),
Salary float,
Designation nvarchar(50),
DOJ date)

create table Emps_LogInfo
(LogId int primary key identity,
Id int,
Fname nvarchar(50),
Lname nvarchar(50),
Salary float,
Designation nvarchar(50),
DOJ date,
Log_Action nvarchar(100),
Action_Time date)
select * from Emps
select * from Emps_LogInfo

create trigger afterITrg
on Emps
after insert
as
begin
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @sal float
declare @desg nvarchar(50)
declare @doj date
declare @action nvarchar(100)
select @id = Id, @fn = Fname, @ln = Lname, @sal = Salary, @desg = Designation, @doj = DOJ from inserted
select @action='After Insert: Record Inserted'

insert into Emps_LogInfo(Id, Fname, Lname, Salary, Designation, DOJ, Log_Action, Action_Time)
values
(@id, @fn, @ln, @sal, @desg, @doj, @action, getdate())
if(@@rowcount>=1)
begin
print 'After Trigger Says: Record Inserted and Your action has been captured in the Log_Info Table'
end
end

insert into Emps(Id,Fname,Lname,Designation,Salary,DOJ) values (1,'Raj', 'Kumar', 'Manager', 98000.50,'12/12/2012')
select * from Emps
select * from Emps_LogInfo

create table Salary
(Grade nvarchar(50) primary key,
BSalary float not null,
HRA as BSalary*0.10 persisted,
TA as BSalary*0.15 persisted,
DA as BSalary*0.15 persisted)

insert into Salary values ('A', 50000)
select * from Salary

insert into Salary values ('B', 40000)
select * from Salary
