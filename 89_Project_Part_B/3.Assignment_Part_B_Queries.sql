-- List of Students
select * from Students

--List of Trainers
select * from Trainers

--List of Courses
select * from Courses

--List of Assignments
select * from Assignments

--List of Students in Courses
select [Course ID], [Student ID], [Course Title], [Student Name],
case
	when [Multiple Courses] = 1 THEN 'True'
    when [Multiple Courses] = 0 THEN 'False'
end as [Multiple Courses]
from [Students in Courses]

--List of Trainers in Courses
select * from [Trainers in Courses]

--List of Assignments per Course
select *
from Assignments
inner join Courses
on Assignments.[Course ID] = Courses.[Course ID]

--List of Assignments per Course Per Student
select *
from Assignments
inner join [Students in Courses]
on Assignments.[Course ID] = [Students in Courses].[Course ID]

--List of Students that belong in more than one course
select distinct [Course ID], [Student ID], [Course Title], [Student Name],
case
	when [Multiple Courses] = 1 THEN 'True'
    when [Multiple Courses] = 0 THEN 'False'
end as [Multiple Courses]
from [Students in Courses] where [Multiple Courses] = 'True'