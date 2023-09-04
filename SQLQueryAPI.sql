create database BookDb
use BookDb

create table Category
(CId int primary key,
CName nvarchar(50) not null unique)

create table Book
(BId int primary key,
BookName nvarchar(50) not null,
BookCategory int foreign key references Category,
Author nvarchar(50) not null,
Price float)

insert into Category values(1, 'Sci-Fi')
insert into Category values(2,'History')
insert into Category values(3,'Drama')
insert into Category values(4,'Fiction')

insert into Book values (1, 'Lord of The Rings Trilogy', 4,'JRR Tolkien',4000.50)
insert into Book values(2,'Wings of Fire', 1,'APJ Abdul Kalam', 550)
insert into Book values(3, 'The Housing Crisis of 2008', 2,'Alan S Blinder',600.25)
insert into Book values(4,'Letters From A Father to His Daughter', 3,'Pt. Nehru', 1250)

select * from Category
select * from Book