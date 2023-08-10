USE master;
GO

-- Dropping the database if it exists
IF DB_ID('OurExerciseDb') IS NOT NULL
    DROP DATABASE OurExerciseDb;
GO

-- Create the database
CREATE DATABASE OurExerciseDb
ON PRIMARY
    (NAME = 'OurExerciseDb_Data',
    FILENAME = 'D:\Mphasis\Live Session\Phase 2\Day1\OurExerciseDb_Data.mdf',
    SIZE = 24MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 8MB)
LOG ON
    (NAME = 'OurExerciseDb_Log',
    FILENAME = 'D:\Mphasis\Live Session\Phase 2\Day1\OurExerciseDb_Log.ldf',
    SIZE = 8MB,
    MAXSIZE = 2048GB,
    FILEGROWTH = 10%);
GO

USE OurExerciseDb;
GO

-- Creating the StudentRegistrations table
CREATE TABLE StudentRegistrations (
    StudentId INT,
    CourseCode NVARCHAR(50),
    RegistrationDate DATE,
    CONSTRAINT PK_StudentRegistrations PRIMARY KEY (StudentId, CourseCode)
);
GO

-- Inserting records into the StudentRegistrations table
INSERT INTO StudentRegistrations (StudentId, CourseCode, RegistrationDate)
VALUES (1, 'CSE111', '2023-08-10'),
       (1, 'EEE222', '2023-08-11'),
       (2, 'ECE333', '2023-08-12'),
       (3, 'CHEM444', '2023-08-13'),
       (2, 'CSE111', '2023-08-14');
GO

-- Verifying the inserted records
SELECT * FROM StudentRegistrations;
GO
