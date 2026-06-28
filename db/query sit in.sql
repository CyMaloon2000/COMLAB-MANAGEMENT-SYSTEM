CREATE DATABASE CLMS
GO
USE CLMS
GO
CREATE TABLE Gender
(
GenderId int primary key identity(1,1),
GenderName varchar(50)
) 
GO
CREATE TABLE Person
(
PersonId int primary key identity(1,1),
Lastname varchar(100),
Firstname varchar(100),
Middlename varchar(100),
Birthdate datetime,
GenderId int foreign key references Gender(GenderId),
Email varchar(100)
)
GO
CREATE TABLE Admin
(
AdminId int primary key identity(1,1),
PersonId int foreign key references person(PersonId),
Username varchar(50),
Password varchar(50),
IsActive bit default 1
)

CREATE TABLE Student
(
StudentId int primary key identity(1,1),
PersonId int foreign key references Person(PersonId),
StudentNo varchar(20)
)
GO
CREATE TABLE Laboratory
(
LaboratoryId int primary key identity(1,1),
LaboratoryName varchar(100),
LaboratoryCode varchar(50),
IsActive bit
)
GO
CREATE TABLE Computer
(
ComputerId int primary key identity(1,1),
ComputerName varchar(50),
ComputerCode varchar(50),
LaboratoryId int foreign key references Laboratory(LaboratoryId),
IsActive bit
)
GO
CREATE TABLE StatusType
(
StatusTypeId int primary key identity(1,1),
StatusTypeName varchar(50)
)
GO
CREATE TABLE Term
(
TermId int primary key identity(1,1),
TermName varchar(100),
DateFrom datetime,
DateTo datetime,
IsActive bit
)
GO
CREATE TABLE Reservation
(
ReservationId int primary key identity(1,1),
StudentId int foreign key references Student(StudentId),
LaboratoryId int foreign key references Laboratory(LaboratoryId),
ComputerId int foreign key references Computer(ComputerId),
TermId int foreign key references Term(TermId),
StatusTypeId int foreign key references StatusType(StatusTypeId)
)
GO
CREATE TABLE ReservationDetail
(
ReservationDetail int primary key identity(1,1),
ReservationId int foreign key references Reservation(ReservationId),
DateStart datetime default GETDATE(),
DateEnd datetime default null
)
GO
INSERT INTO GENDER
VALUES ('MALE')
GO
INSERT INTO GENDER
VALUES ('FEMALE')


select * from Person