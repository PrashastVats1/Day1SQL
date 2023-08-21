create database LibraryDb
use LibraryDb

create table Books
(BookId int primary key,
Title nvarchar(100) not null,
Author nvarchar(100) not null,
Genre nvarchar(50),
Quantity int)

insert into Books values (1,'Lord of THe Rings Trilogy','JRR Tolkien','Fantasy, Adventure',500)
insert into Books values (2,'Harry Potter Series','JK Rowling','Action, Magic',450)
insert into Books values (3,'The Inheritance Cycle','Christopher Paolini','Adventure, Magic',350)
insert into Books values (4,'Chronicles of Narnia','CS Lewis','Action, Fantasy',400)
insert into Books values (5,'Sherlock Holmes Series','Sir Arthur Conan Doyle','Mystery, Thriller',480)
insert into Books values (6,'Deal with the Devil','CrossEdge','Fantasy, Adventure',120)
insert into Books values (7,'Inferno','Dan Brown','Sci-fi, Thriller',300)
insert into Books values (8,'Everyone Else is a Returnee','Toika','Martial Arts, Supernatural',250)
select * from Books