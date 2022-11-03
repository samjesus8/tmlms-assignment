using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    public class Student
    {
        public string StudentName { get; set; }
        public int Id { get; set; }

        public Student(string name) 
        {
            StudentName = name;

            var Random = new Random();
            Id = Random.Next(0, 10000000);
        }
    }
}
