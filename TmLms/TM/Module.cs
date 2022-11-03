using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmLms.Users;

namespace TmLms.TM
{
    public class Module
    {
        public enum CreditEnum
        {
            TWENTY = 20,
            FORTY = 40,
            SIXTY = 60
        }

        public enum LevelEnum
        {
            FOUR = 4,
            FIVE = 5,
            SIX = 6
        }

        public Course CourseName { get; set; }
        public List<Administrator> Admins { get; set; }
        public SortedSet<Student> Students { get; set; } //List to store members in a module

        public string Code { get; set; } //Module ID number
        public string Name { get; set; } //Module name
        public string Description { get; set; } //Module Description

        public LevelEnum Level { get; set; }
        public CreditEnum Credits { get; set; }

        public Module(Course course, string moduleName, string moduleDescription, int credits, Administrator[] AdminList, Student[] studentList)  //MAIN CONSTRUCTOR
        {
            Admins = new List<Administrator>(); //Initialising all Lists
            Students = new SortedSet<Student>();

            CourseName = course; //Getting the course we want to add this module to

            var Random = new Random();

            Code = "MO" + Random.Next(0, 99999).ToString(); //Module ID randomly Generated
            Name = moduleName; //Parse in Module name from user input
            Description = moduleDescription; //Parse in Module Description from user input
            CheckCredits(credits); //Checks the credits parsed in and assigns value to Credits

            foreach (var admin in AdminList) //Storing List of Admins
            {
                Admins.Add(admin);
            }

            foreach(var student in studentList) //Storing List of Students
            {
                Students.Add(student);
            }
        }

        public override int GetHashCode() //Method to check for same ID number (Eliminates Conflicts)
        {
            return this.Code.GetHashCode();
        }

        public override bool Equals(object? obj) //Error checking for empty IDs
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Object", "The object trying to compare is null");
            }

            return ((Module)obj).Code == this.Code;
        }

        private void CheckCredits(int credits) 
        {
            if (credits == 20) 
            {
                Credits = CreditEnum.TWENTY;
            }
            else if (credits == 40) 
            {
                Credits = CreditEnum.FORTY;
            }
            else if (credits == 60) 
            {
                Credits = CreditEnum.SIXTY;
            }
        }
    }
}
