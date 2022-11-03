using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmLms.TM;
using TmLms.Users;

namespace TmLms
{
    public sealed class TMEngine
    {
        //TM Dictionarys
        public Dictionary<int, TM.Course> CourseDictionary { get; set; }
        public Dictionary<int, TM.Module> ModuleDictionary { get; set; }

        //User Dictionarys
        public Dictionary<int, Users.Instructor> Instructors { get; set; }
        public Dictionary<int, Users.Administrator> Admins { get; set; }
        public Dictionary<int, Users.Student> Students { get; set; }

        public static readonly TMEngine instance = new TMEngine();

        static TMEngine()
        {
        }

        private TMEngine()
        {
            CourseDictionary = new Dictionary<int, TM.Course>();
            ModuleDictionary = new Dictionary<int, TM.Module>();
            Instructors = new Dictionary<int, Users.Instructor>();
            Students = new Dictionary<int, Users.Student>();
            Admins = new Dictionary<int, Users.Administrator>();
        }

        public static TMEngine Instance
        {
            get
            {
                return instance;
            }
        }

        public void LoadDummyData() 
        {
            //Instructors
            var Instructor1 = new Instructor("Mr Anderson");
            var Instructor2 = new Instructor("Mr Malkovich");
            var Instructor3 = new Instructor("Mr Folabi");
            var Instructor4 = new Instructor("Mr Uvuvwevwevwe onyetenvewve ugwemubwem ossas");

            Instructors.Add(1, Instructor1);
            Instructors.Add(2, Instructor2);
            Instructors.Add(3, Instructor3);
            Instructors.Add(4, Instructor4);

            //Admins
            var Admin1 = new Administrator("Mark");
            var Admin2 = new Administrator("Paul");
            var Admin3 = new Administrator("Rob");

            Admins.Add(1, Admin1);
            Admins.Add(2, Admin2);
            Admins.Add(3, Admin3);

            //Students
            var Student1 = new Student("Katie");
            var Student2 = new Student("Bob");
            var Student3 = new Student("Luke");
            var Student4 = new Student("Peter");

            Students.Add(1, Student1);
            Students.Add(2, Student2);
            Students.Add(3, Student3);
            Students.Add(4, Student4);

            //Courses

            var Course1 = new Course("Computer Science BSc", (Instructor1.ID + " - " + Instructor1.InstructorName), 4, 120, "C# Coding Course");
            CourseDictionary.Add(0, Course1);
        }
    }
}
