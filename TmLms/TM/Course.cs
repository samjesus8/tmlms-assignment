using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.TM
{
    public class Course
    {
        public string? Instructor { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Level { get; set; }
        public int Credits { get; set; }

        private int Level4Slot = 20;
        private int Level5Slot = 40;
        private int Level6Slot = 100;


        public bool AddModule(Module moduleToAdd, bool isCore)
        {
            return false;
        }

        public void DeleteModule()
        {

        }

        public Course(string CourseName, string InstructorName, int CourseLevel, int Credits, string Description) 
        {
            this.Name = CourseName;
            this.Description = Description;
            this.Instructor = InstructorName;
            this.Level = CourseLevel;
            this.Credits = Credits;
        }

        public Course() 
        {

        }
    }
}
