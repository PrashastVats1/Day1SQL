--create database
create database Assessment05Db
--if database already exists drop it
drop database Assessment05Db

use Assessment05Db

--creating schema bank
create schema bank
--creating customer table

create table bank.Customer
(CId int primary key identity(1000,1),
CName nvarchar(50) not null,
CEmail nvarchar(100) not null unique,
CContact nvarchar(50) not null unique check (CContact like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
CPwd as right(CName,2)+convert(nvarchar(10), CId)+left(CContact,2) persisted)
--creating mailinfo table
create table bank.MailInfo
(MailTo nvarchar(100),
MailDate date default getdate(),
MailMessage nvarchar(255))
--creating the trigger trgMailToCust

create trigger bank.trgMailToCust on bank.Customer
after insert as
begin
declare @CEmail nvarchar(100), @CPwd nvarchar(50)
select @CEmail = CEmail, @CPwd = CPwd from inserted
insert into bank.MailInfo(MailTo, MailMessage)
values(@CEmail,
'Your net banking password is: ' + @CPwd + '.' +
' It is valid for 2 days only, kindly update it.')
end
insert into bank.Customer(CName, CEmail, CContact) values ('Raju Ramesh', 'rajuramesh@sql.com', '9999999999')
insert into bank.Customer(CName, CEmail, CContact) values ('Raju Shrivastav', 'rajushrivastav@sql.com', '8888888888')
insert into bank.Customer(CName, CEmail, CContact) values ('Ram Mohan', 'rammohan@sql.com', '7777777777')
insert into bank.Customer(CName, CEmail, CContact) values ('Mahesh Dalle', 'maheshdalle@sql.com', '6666666666')
insert into bank.Customer(CName, CEmail, CContact) values ('Rakesh Rajni', 'rakeshrajni@sql.com', '5555555555')
insert into bank.Customer(CName, CEmail, CContact) values ('Mayuri Shitetsu', 'mayurishitetsu@sql.com', '4444444444')
insert into bank.Customer(CName, CEmail, CContact) values ('Sora Shiro', 'sorashiro@sql.com', '3333333333')
insert into bank.Customer(CName, CEmail, CContact) values ('Jibril Stephanie', 'jibrilstephanie@sql.com', '2222222222')
insert into bank.Customer(CName, CEmail, CContact) values ('Fii Miko', 'fiimiko@sql.com', '1111111111')
insert into bank.Customer(CName, CEmail, CContact) values ('Thug Life', 'thuglife@sql.com', '0000000000')

select * from bank.Customer
select * from bank.MailInfo
