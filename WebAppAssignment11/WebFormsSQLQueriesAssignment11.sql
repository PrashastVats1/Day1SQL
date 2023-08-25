create database ContentDb
use ContentDb

create table Articles
(ArticleId int primary key,
Title nvarchar(100),
Content nvarchar(max),
PublishDate datetime)

insert into Articles values (1,'India Chandrayan3 Mission','The Chandrayan3 Lander Module landed on the moon on 24/08/2023 at the scheduled 06:04 PM. By doing so, India has also created history by becoming the one and only country to land at the south pole of the Moon.','08/25/2023')
insert into Articles values (2,'One Piece Live Action Looks Promising!!','The global Netflix release of the live-action "One Piece" series is scheduled for Thursday, August 31, 2023. The inaugural eight episodes will encompass nearly the entirety of the East Blue Saga of "One Piece."','08/07/2023')
insert into Articles values (3,'Rise of Youtube','The simplicity of YouTube is one of the many reasons why it has exploded in popularity over the years. YouTube makes it so easy for content creators to share their content with a large audience. And as a result, there is a wide range of content to choose from.','04/18/2019')
insert into Articles values (4,'Rise of IoT','The latest IoT Analytics “State of IoT—Spring 2023” report shows that the number of global IoT connections grew by 18% in 2022 to 14.3 billion active IoT endpoints. In 2023, IoT Analytics expects the global number of connected IoT devices to grow another 16%, to 16.7 billion active endpoints.','05/30/2023')
insert into Articles values (5,'Why is Apple so successful?','One of the primary reasons for the success of Apple is its focus on innovation and design. The company has a team of designers and engineers who work tirelessly to create products that are not only functional but also aesthetically pleasing.','11/04/2022')

select * from Articles