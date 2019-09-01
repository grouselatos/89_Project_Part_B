using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Project_Part_B
{
    class Course
    {
        public int course_id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string stream { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }

        public List<Assignment> assignments = new List<Assignment>();
        public List<Student> students = new List<Student>();
        public List<Trainer> trainers = new List<Trainer>();

        public override string ToString()
        {
            return $"{course_id}, {title}, {type}, {stream}, {start_date}, {end_date}";
        }
    }
}
