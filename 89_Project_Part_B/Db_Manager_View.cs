using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _89_Project_Part_B
{
    class Db_Manager_View
    {
        private readonly string conn_string = @"Data Source=LAPTOP-J5OLM510\SQLEXPRESS;Initial Catalog='Academy Data';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Student> ViewStudents()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("select * from Students", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                student_id= (int)reader["Student ID"],
                                contact_name = (string)reader["Contact Name"],
                                date_of_birth = (DateTime)reader["Date of Birth"],
                                tuition_fees = (int)reader["Tuition Fees"]
                            });
                        }
                    }
                }
            }
            return students;
        }

        public List<Trainer> ViewTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("select * from Trainers", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            trainers.Add(new Trainer
                            {
                                trainer_id = (int)reader["Trainer ID"],
                                contact_name = (string)reader["Contact Name"],
                                subject = (string)reader["Subject"],
                            });
                        }
                    }
                }
            }
            return trainers;
        }

        public List<Course> ViewCourses()
        {
            List<Course> courses = new List<Course>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("select * from Courses", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course
                            {
                                course_id = (int)reader["Course ID"],
                                title = (string)reader["Title"],
                                type = (string)reader["Type"],
                                stream = (string)reader["Stream"],
                                start_date = (DateTime)reader["Start Date"],
                                end_date = (DateTime)reader["End Date"]
                            });
                        }
                    }
                }
            }
            return courses;
        }

        public List<Assignment> ViewAssignments()
        {
            List<Assignment> assignments = new List<Assignment>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("select * from Assignments", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            assignments.Add(new Assignment
                            {
                                assignment_id = (int)reader["Assignment ID"],
                                title = (string)reader["Title"],
                                description = (string)reader["Description"],
                                oral_mark = (decimal)reader["Oral Mark"],
                                total_mark = (decimal)reader["Total Mark"],
                                student_id = (int)reader["Student ID"],
                                course_id = (int)reader["Course ID"]

                            });
                        }
                    }
                }
            }
            return assignments;
        }

        public List<Student_in_Course> ViewStudentsInCourses()
        {
            List<Student_in_Course> studentscourses = new List<Student_in_Course>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("select [Course ID], [Student ID], [Course Title], [Student Name], " +
                    "case when [Multiple Courses] = 1 THEN 'True'" +
                    "when[Multiple Courses] = 0 THEN 'False'" +
                    "end as [Multiple Courses]" +
                    "from[Students in Courses]", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentscourses.Add(new Student_in_Course
                            {
                                course_id = (int)reader["Course ID"],
                                student_id = (int)reader["Student ID"],
                                course_title = (string)reader["Course Title"],
                                student_name = (string)reader["Student Name"],
                                multiple_courses = (string)reader["Multiple Courses"]
                            });
                        }
                    }
                }
            }
            return studentscourses;
        }

        public List<Trainer_in_Course> ViewTrainersInCourses()
        {
            List<Trainer_in_Course> trainerscourses = new List<Trainer_in_Course>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("select * from [Trainers in Courses]", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            trainerscourses.Add(new Trainer_in_Course
                            {
                                course_id = (int)reader["Course ID"],
                                trainer_id = (int)reader["Trainer ID"],
                                course_title= (string)reader["Course Title"],
                                trainer_name = (string)reader["Trainer Name"]
                            });
                        }
                    }
                }
            }
            return trainerscourses;
        }

        public List<Assignment> ViewAssignmentsStudentsCourses()
        {
            List<Assignment> assignmentssc= new List<Assignment>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("select * from Assignments " +
                    "inner join [Students in Courses] on Assignments.[Course ID] = " +
                    "[Students in Courses].[Course ID]", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            assignmentssc.Add(new Assignment
                            {
                                assignment_id = (int)reader["Assignment ID"],
                                title = (string)reader["Title"],
                                description = (string)reader["Description"],
                                oral_mark = (decimal)reader["Oral Mark"],
                                total_mark = (decimal)reader["Total Mark"],
                                student_id = (int)reader["Student ID"],
                                course_id = (int)reader["Course ID"]
                            });
                        }
                    }
                }
            }
            return assignmentssc;
        }

        public List<Student_in_Course> ViewStudentsInCourses(bool multiple)
        {
            List<Student_in_Course> studentscoursesm = new List<Student_in_Course>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("select * from [Students in Courses] where [Multiple Courses] = @multiple", conn))
                {
                    command.Parameters.Add(new SqlParameter("multiple", Convert.ToInt32(multiple)));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentscoursesm.Add(new Student_in_Course
                            {
                                course_id = (int)reader["Course ID"],
                                student_id = (int)reader["Student ID"],
                                course_title = (string)reader["Course Title"],
                                student_name = (string)reader["Student Name"],
                                multiple_courses = (string)reader["Multiple Courses"]
                            });
                        }
                    }
                }
            }
            return studentscoursesm;
        }

    }
}
