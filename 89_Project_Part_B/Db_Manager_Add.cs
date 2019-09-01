using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _89_Project_Part_B
{
    class Db_Manager_Add
    {
        private readonly string conn_string = @"Data Source=LAPTOP-J5OLM510\SQLEXPRESS;Initial Catalog='Academy Data';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void AddStudent(string contact_name, DateTime dob, int tuition_fees)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("insert into Students values(@contact_name, @dob, @tuition_fees)", conn))
                {
                    command.Parameters.Add(new SqlParameter("contact_name", contact_name));
                    command.Parameters.Add(new SqlParameter("dob", dob));
                    command.Parameters.Add(new SqlParameter("tuition_fees", tuition_fees));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddTrainer(string contact_name, string subject)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("insert into Trainers values(@contact_name, @subject)", conn))
                {
                    command.Parameters.Add(new SqlParameter("contact_name", contact_name));
                    command.Parameters.Add(new SqlParameter("subject", subject));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddCourse(string title, string type, string stream, DateTime st_date, DateTime en_date)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("insert into Courses values(@title, @type, @stream, @st_date, @en_date)", conn))
                {
                    command.Parameters.Add(new SqlParameter("title", title));
                    command.Parameters.Add(new SqlParameter("type", type));
                    command.Parameters.Add(new SqlParameter("stream", stream));
                    command.Parameters.Add(new SqlParameter("st_date", st_date));
                    command.Parameters.Add(new SqlParameter("en_date", en_date));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddAssignment(string title, string description, decimal oral_mark, decimal total_mark, int student_id, int course_id)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("insert into Assignments values(@title, @description, @oral_mark, @total_mark, @student_id, @course_id)", conn))
                {
                    command.Parameters.Add(new SqlParameter("title", title));
                    command.Parameters.Add(new SqlParameter("description", description));
                    command.Parameters.Add(new SqlParameter("oral_mark", oral_mark));
                    command.Parameters.Add(new SqlParameter("total_mark", total_mark));
                    command.Parameters.Add(new SqlParameter("student_id", student_id));
                    command.Parameters.Add(new SqlParameter("course_id", course_id));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddStudentToCourse(int course_id, int student_id, string course_title, string student_name, string multiple_course)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("insert into [Students in Courses] values(@course_id, @student_id, @course_title, @student_name, @multiple_course)", conn))
                {
                    command.Parameters.Add(new SqlParameter("course_id", course_id));
                    command.Parameters.Add(new SqlParameter("student_id", student_id));
                    command.Parameters.Add(new SqlParameter("course_title", course_title));
                    command.Parameters.Add(new SqlParameter("student_name", student_name));
                    command.Parameters.Add(new SqlParameter("multiple_course", multiple_course));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddTrainerToCourse(int course_id, int trainer_id, string course_title, string trainer_name)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("insert into [Trainers in Courses] values(@course_id, @trainer_id, @course_title, @trainer_name)", conn))
                {
                    command.Parameters.Add(new SqlParameter("course_id", course_id));
                    command.Parameters.Add(new SqlParameter("trainer_id", trainer_id));
                    command.Parameters.Add(new SqlParameter("course_title", course_title));
                    command.Parameters.Add(new SqlParameter("trainer_name", trainer_name));
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
