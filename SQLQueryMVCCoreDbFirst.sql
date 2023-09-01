create database PlayersDb
use PlayersDb

create table team
(TeamId int primary key,
TeamName nvarchar(50) not null unique)
create table Player
(PlayerId int primary key,
PlayerName nvarchar(50) not null,
PlayerType nvarchar(50) not null,
PlayerTeam int foreign key references Team(TeamId))

insert into Team values (1,'CSK'), (2,'RCB'),(3,'KKr'),(4,'DC')

insert into Player values (1,'MSD','Wicketkeeper/ Batsman', 1)
insert into Player values (2,'Virat Kohli', 'Batsman',2)
insert into Player values (3,'M.Siraj','Baller', 2)