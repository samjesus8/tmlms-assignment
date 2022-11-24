using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    public class Instructor
    {
        public string InstructorName { get; set; }
        public int ID { get; set; }

        public Instructor(string Name, int id) 
        {
            this.InstructorName = Name;
            this.ID = id;
        }
        public Instructor() { }
    }
}
