use [Academy Data]
go

--Edited [Students in Courses] Table
alter table [Students in Courses]
add [Multiple Courses] bit not null

-- Data insertion in dbo.Students
INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Tobias Smith'
           ,('20000618')
           ,2400)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Claire Gibson'
           ,('20000713')
           ,2400)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Jacob Smith'
           ,('20000924')
           ,2400)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Kingsley Talbott'
           ,('20000330')
           ,2400)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Gabriella Goodwin'
           ,('20000317')
           ,0)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Ellie Navis'
           ,('2000828')
           ,2400)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Nathan Kent'
           ,('20000412')
           ,0)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Bill Norris'
           ,('20000520')
           ,2400)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Tommy Jones'
           ,('20000611')
           ,0)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Vince Sain'
           ,('20001105')
           ,2000)
GO

INSERT INTO [dbo].[Students]
           ([Contact Name]
           ,[Date of Birth]
           ,[Tuition Fees])
     VALUES
           ('Jennifer Svent'
           ,('20001014')
           ,2400)
GO

-- Data insertion in dbo.Trainers
INSERT INTO [dbo].[Trainers]
           ([Contact Name]
           ,[Subject])
     VALUES
           ('Tony Stark'
           ,'Technology and Engineering')
GO

INSERT INTO [dbo].[Trainers]
           ([Contact Name]
           ,[Subject])
     VALUES
           ('Steve Rogers'
           ,'Combatives and Leadership')
GO

INSERT INTO [dbo].[Trainers]
           ([Contact Name]
           ,[Subject])
     VALUES
           ('Bruce Banner'
           ,'Gamma Rays and Mutations')
GO

INSERT INTO [dbo].[Trainers]
           ([Contact Name]
           ,[Subject])
     VALUES
           ('Thor Odinssonn'
           ,'How to be Worthy')
GO

INSERT INTO [dbo].[Trainers]
           ([Contact Name]
           ,[Subject])
     VALUES
           ('Natasha Romanova'
           ,'Hand-to-Hand Combat')
GO

INSERT INTO [dbo].[Trainers]
           ([Contact Name]
           ,[Subject])
     VALUES
           ('Clint Barton'
           ,'Range is the Game')
GO

--Data Insertion in dbo.Courses
INSERT INTO [dbo].[Courses]
           ([Title]
           ,[Type]
           ,[Stream]
           ,[Start Date]
           ,[End Date])
     VALUES
           ('SuperHero Hacking'
           ,'Technology'
           ,'Full-Time'
           ,'20190915'
           ,'20190610')

GO

INSERT INTO [dbo].[Courses]
           ([Title]
           ,[Type]
           ,[Stream]
           ,[Start Date]
           ,[End Date])
	 VALUES
           ('SuperHero Politics'
           ,'Philosophical'
           ,'Part-Time'
           ,'20190915'
           ,'20190610')

GO

INSERT INTO [dbo].[Courses]
           ([Title]
           ,[Type]
           ,[Stream]
           ,[Start Date]
           ,[End Date])
     VALUES
           ('Ultimate Combat'
           ,'Fighting'
           ,'Full-Time'
           ,'20190915'
           ,'20190610')

GO

INSERT INTO [dbo].[Courses]
           ([Title]
           ,[Type]
           ,[Stream]
           ,[Start Date]
           ,[End Date])
     VALUES
           ('Enemy Engagement'
           ,'Strategy'
           ,'Full-Time'
           ,'20190915'
           ,'20190610')

GO

INSERT INTO [dbo].[Courses]
           ([Title]
           ,[Type]
           ,[Stream]
           ,[Start Date]
           ,[End Date])
     VALUES
           ('SuperHero Leadership'
           ,'Practical Skills'
           ,'Part-Time'
           ,'20190915'
           ,'20190610')

GO

--Data Insertion in dbo.Assignments
INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 1'
           ,'Introductory Level'
           ,('85.5')
           ,('80.4')
           ,('3')
           ,('2'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 4'
           ,'Introductory Level'
           ,('70.5')
           ,('81.0')
           ,('3')
           ,('2'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 11'
           ,'Difficult Level'
           ,('64.3')
           ,('70.0')
           ,('5')
           ,('1'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 2'
           ,'Normal Level'
           ,('65.5')
           ,('82.0')
           ,('4')
           ,('5'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 7'
           ,'Normal Level'
           ,('95.5')
           ,('91.0')
           ,('12')
           ,('3'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 6'
           ,'Introductory Level'
           ,('76.5')
           ,('80.0')
           ,('11')
           ,('4'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 15'
           ,'Easy Level'
           ,('83.0')
           ,('86.0')
           ,('10')
           ,('2'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 16'
           ,'Difficult Level'
           ,('90.5')
           ,('80.0')
           ,('11')
           ,('1'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 22'
           ,'Normal Level'
           ,('85.5')
           ,('80.0')
           ,('9')
           ,('5'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 24'
           ,'Normal Level'
           ,('89.5')
           ,('94.0')
           ,('9')
           ,('5'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 21'
           ,'Normal Level'
           ,('75.5')
           ,('88.0')
           ,('8')
           ,('5'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 25'
           ,'Difficult Level'
           ,('82.5')
           ,('81.0')
           ,('4')
           ,('3'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 18'
           ,'Difficult Level'
           ,('85.5')
           ,('80.0')
           ,('10')
           ,('4'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 30'
           ,'Introductory Level'
           ,('94.3')
           ,('98.0')
           ,('4')
           ,('1'))
GO

INSERT INTO [dbo].[Assignments]
           ([Title]
           ,[Description]
           ,[Oral Mark]
           ,[Total Mark]
           ,[Student ID]
           ,[Course ID])
     VALUES
           ('Assignment Task 26'
           ,'Easy Level'
           ,('84.5')
           ,('80.0')
           ,('9')
           ,('3'))
GO
