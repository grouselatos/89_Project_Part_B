using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Project_Part_B
{
    class Trainer_in_Course
    {
        public int course_id { get; set; }
        public int trainer_id { get; set; }
        public string course_title { get; set; }
        public string trainer_name { get; set; }

        public List<Trainer> trainers = new List<Trainer>();
        public List<Course> courses = new List<Course>();

        public override string ToString()
        {
            return $"{course_id}, {trainer_id}, {course_title}, {trainer_name}";
        }
    }
}
