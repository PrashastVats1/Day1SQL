create database PlayerMgmtDb
use PlayerMgmtDb

create table Players
(PlayerId int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
JerseyNumber int,
Position nvarchar(50),
Team nvarchar(50))

insert into Players values (1,'Rohit','Sharma',45,'Captain','Mumbai Indians')
insert into Players values (2,'Mahendra Singh','Dhoni',07,'Captain','Chennai Super Kings')
insert into Players values (3,'Ben','Stokes',55,'Batsman','Chennai Super Kings')
insert into Players values (4,'Virat','Kohli',18,'Captain','Royal Challengers Bangalore')
insert into Players values (5,'KL','Rahul',01,'Batsman/ Wicket Keeper','Punjab Kings')
insert into Players values (6,'Jasprit','Bumra',93,'Bowler','Mumbai Indians')
insert into Players values (7,'Rashid','Khan',11,'Bowler','Sunrisers Hyderabad')
insert into Players values (8,'Shikhar','Dhawan',25,'Batsman','Delhi Capitals')
insert into Players values (9,'Yuzvendra','Chahal',03,'Bowler','Royal Challengers Bangalore')
insert into Players values (10,'Imran','Tahir',77,'Bowler','Chennai Super Kings')

select * from Players