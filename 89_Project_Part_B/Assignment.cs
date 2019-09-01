using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Project_Part_B
{
    class Assignment
    {
        public int assignment_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal oral_mark { get; set; }
        public decimal total_mark { get; set; }

        public int student_id { get; set; }
        public int course_id { get; set; }

        public override string ToString()
        {
            return $"{assignment_id}, {title}, {description}, {oral_mark}, {total_mark}, {student_id}, {course_id}";
        }
    }
}
