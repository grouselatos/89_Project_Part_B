--Database Creation
use master
go

drop database if exists [Academy Data]
create database [Academy Data]
go

use [Academy Data]
go

--Tables Creation
create table Students(
	[Student ID] int Identity(1,1) primary key,
	[Contact Name] varchar(30) not null,
	[Date of Birth] datetime,
	[Tuition Fees] int,
	)
	go

create table Trainers(
	[Trainer ID] int Identity(1,1) primary key,
	[Contact Name] varchar(30) not null,
	[Subject] varchar(30),
	)
	go

create table Courses(
	[Course ID] int Identity(1,1) primary key,
	Title varchar(30) not null,
	[Type] varchar(30),
	Stream varchar(30),
	[Start Date] Date,
	[End Date] Date,
	)
	go

create table Assignments(
	[Assignment ID] int Identity(1,1) primary key,
	[Title] varchar(30) not null,
	[Description] varchar(30),
	[Oral Mark] decimal(3,1),
	[Total Mark] decimal(3,1),
	[Student ID] int references Students,
	[Course ID] int references Courses
	)
	go

create table [Students in Courses](
	[Course ID] int references Courses,
	[Student ID] int references Students,
	[Course Title] varchar(30) not null,
	[Student Name] varchar(30) not null,
	)
	go

create table [Trainers in Courses](
	[Course ID] int references Courses,
	[Trainer ID] int references Trainers,
	[Course Title] varchar(30) not null,
	[Trainer Name] varchar(30) not null,
	)
	go