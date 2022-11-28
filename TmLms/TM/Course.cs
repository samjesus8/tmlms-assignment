using TmLms.Users;

namespace TmLms.TM
{
    public class Course
    {
        public Dictionary<int, Instructor> InstructorDir = new Dictionary<int, Instructor>(); // <ID, InstructorClass>
        public Dictionary<string, Module> ModuleDir = new Dictionary<string, Module>();//<ModuleCode, ModuleClass>
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Level { get; set; }
        public int Credits { get; set; }

        public bool AddModule(Module moduleToAdd, bool isCore)
        {
            return false;
        }

        public void DeleteModule()
        {

        }

        public Course(string CourseName, Instructor[] instructors, int CourseLevel, int Credits, string Description) 
        {
            this.Name = CourseName;
            this.Description = Description;
            this.Level = CourseLevel;
            this.Credits = Credits;

            for (int i = 0; i < instructors.Length; i++) 
            {
                InstructorDir.Add(instructors[i].ID, instructors[i]); //Adding Instructors to the Dictionary
            }
        }

        public Course() 
        {

        }
    }
}
