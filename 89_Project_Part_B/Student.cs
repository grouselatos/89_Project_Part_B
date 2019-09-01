using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Project_Part_B
{
    class Student
    {
        public int student_id { get; set; }
        public string contact_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public int tuition_fees { get; set; }

        public List<Assignment> assignments = new List<Assignment>();
        public List<Course> courses = new List<Course>();

        public override string ToString()
        {
            return $"{student_id}, {contact_name}, {date_of_birth}, {tuition_fees}";
        }
    }
}
