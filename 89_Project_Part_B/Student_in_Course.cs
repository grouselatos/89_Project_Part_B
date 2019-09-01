using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Project_Part_B
{
    class Student_in_Course
    {
        public int course_id { get; set; }
        public int student_id { get; set; }
        public string course_title { get; set; }
        public string student_name { get; set; }
        public string multiple_courses { get; set; }

        public List<Student> students = new List<Student>();
        public List<Course> courses = new List<Course>();

        public override string ToString()
        {
            return $"{course_id}, {student_id}, {course_title}, {student_name}, {multiple_courses}";
        }
    }
}
