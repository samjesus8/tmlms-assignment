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
        public Dictionary<int, Administrator> Admins = new Dictionary<int, Administrator>();
        public Dictionary<int, Student> Students = new Dictionary<int, Student>();
        public Dictionary<int, Instructor> Instructors = new Dictionary<int, Instructor>();

        public string Code { get; set; } //Module ID number
        public string Name { get; set; } //Module name
        public string Description { get; set; } //Module Description

        public LevelEnum Level { get; set; }
        public CreditEnum Credits { get; set; }

        public Module(Course course, string moduleName, string moduleDescription, int credits, Administrator[] adminList, Student[] studentList, Instructor[] instructorList)  //MAIN CONSTRUCTOR
        {
            CourseName = course; //Getting the course we want to add this module to

            var Random = new Random();

            Code = "MO" + Random.Next(0, 99999).ToString(); //Module ID randomly Generated
            Name = moduleName; //Parse in Module name from user input
            Description = moduleDescription; //Parse in Module Description from user input
            CheckCredits(credits); //Checks the credits parsed in and assigns value to Credits

            foreach (var admin in adminList) //Storing List of Admins
            {
                Admins.Add(admin.ID, admin);
            }

            foreach (var instructor in instructorList) //Storing List of Instructors
            {
                Instructors.Add(instructor.ID, instructor);
            }

            foreach(var student in studentList) //Storing List of Students
            {
                Students.Add(student.ID, student);
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
