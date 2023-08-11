--if database present dropping it
use master
if exists(select name from sys.databases where name = N'ExerciseDb')
drop database ExerciseDb
--creating database
create database ExerciseDb
on primary
(name = ExerciseDb_data,
filename = 'D:\Mphasis\Live Session\Phase 2\Day2\Assignment\ExerciseDb_data.mdf')
use ExerciseDb
--creating table publisher
create table Publisher
(PID int primary key,
Publisher nvarchar(100) not null unique)
--creating table category
create table Category
(CID int primary key,
Category nvarchar(100) not null unique)
--creating table author
create table Author
(AID int primary key,
AuthorName nvarchar(100) not null unique)
--creating table book
create table Book
(BID int primary key,
BName nvarchar(100) not null unique,
BPrice float,
Author int foreign key(Author) references Author(AID),
Publisher int foreign key(Publisher) references Publisher(PID),
Category int foreign key(Category) references Category(CID))
--insert records into publisher table
insert into Publisher (PID, Publisher) values
(1,'The Dawn'),
(2,'The Dummy'),
(3,'The Godfather')
--insert records into category table
insert into Category (CID, Category) values
(1,'Fiction'),
(2,'Adventure'),
(3,'Mystery')
--insert recors into author table
insert into Author(AID, AuthorName) values
(1, 'SS Ram'),
(2, 'PP Pallu'),
(3, 'Blacky Good')
--records into book table
insert into Book(BID, BName, BPrice, Author, Publisher, Category) values
(1, 'The Hobbit', 699.99, 1, 1, 1),
(2, 'Harry Potter Series', 3333.99, 2, 2, 2),
(3, 'BloodBorne', 2000.75, 3, 3, 3),
(4, 'Lord of the Rings Series', 1599.99, 1, 1, 1),
(5, 'Child of Time', 255.25, 2, 2, 2),
(6, 'Dark Souls', 2500.75, 3, 3, 3);

--Display BID BName BPrice Author Publisher Category
select b.BID, b.BName, b.BPrice, a.AuthorName as Author, p.Publisher as PublisherName, c.Category as CategoryName
from Book b join Author a on b.Author=a.AID
join Publisher p on b.Publisher = p.PID
join Category c on b.Category = c.CID