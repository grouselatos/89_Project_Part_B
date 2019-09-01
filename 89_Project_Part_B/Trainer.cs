using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Project_Part_B
{
    class Trainer
    {
        public int trainer_id { get; set; }
        public string contact_name { get; set; }
        public string subject { get; set; }

        public List<Course> courses = new List<Course>();

        public override string ToString()
        {
            return $"{trainer_id}, {contact_name}, {subject}";
        }
    }
}
