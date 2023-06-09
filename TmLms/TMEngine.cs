﻿using TmLms.TM;
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
            var Instructor1 = new Instructor("Mr Anderson", 1);
            var Instructor2 = new Instructor("Mr Malkovich", 2);
            var Instructor3 = new Instructor("Mr Folabi", 3);
            var Instructor4 = new Instructor("Mr Uvuvwevwevwe onyetenvewve ugwemubwem ossas", 4);

            Instructors.Add(1, Instructor1);
            Instructors.Add(2, Instructor2);
            Instructors.Add(3, Instructor3);
            Instructors.Add(4, Instructor4);

            //Admins
            var Admin1 = new Administrator("Mark", 1);
            var Admin2 = new Administrator("Paul", 2);
            var Admin3 = new Administrator("Rob", 3);

            Admins.Add(1, Admin1);
            Admins.Add(2, Admin2);
            Admins.Add(3, Admin3);

            //Students
            var Student1 = new Student("Katie", 1);
            var Student2 = new Student("Bob", 2);
            var Student3 = new Student("Luke", 3);
            var Student4 = new Student("Peter", 4);

            Students.Add(1, Student1);
            Students.Add(2, Student2);
            Students.Add(3, Student3);
            Students.Add(4, Student4);

            //Courses & Modules

            Instructor[] instructorArray = { Instructor1, Instructor2, Instructor3 };

            var Course1 = new Course("Computer Science BSc", instructorArray, 4, 120, "C# Coding Course");
            CourseDictionary.Add(0, Course1);

            Administrator[] Module1Admins = { Admin1, Admin2, Admin3 };
            Student[] Module1Students = { Student2, Student4, Student1 };
            Instructor[] Module1Instructors = { Instructor1, Instructor3 };

            var Module1 = new Module(Course1, "Object Oriented Programming", "C# Coding and shit", 40, Module1Admins, Module1Students, Module1Instructors);
            Course1.ModuleDir.Add("MO12934", Module1);

            var Course2 = new Course("Accounting and Finance BSc", instructorArray, 5, 120, "Money and shit");
            CourseDictionary.Add(1, Course2);

            Administrator[] Module2Admins = { Admin1, Admin3 };
            Student[] Module2Students = { Student4, Student1 };
            Instructor[] Module2Instructors = { Instructor1, Instructor3 };

            var Module2 = new Module(Course2, "VR", "Oculus Rift and shit", 20, Module2Admins, Module2Students, Module2Instructors);
            Course2.ModuleDir.Add("MO12984", Module2);
        }
    }
}
