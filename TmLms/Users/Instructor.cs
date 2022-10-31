using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    internal class Instructor
    {
        public string InstructorName { get; set; }
        public int ID { get; set; }

        public Instructor(string Name) 
        {
            this.InstructorName = Name;

            var Random = new Random();
            this.ID = Random.Next(0, 9999999);
        }
    }
}
