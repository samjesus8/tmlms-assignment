namespace TmLms.Users
{
    public class Student
    {
        public string StudentName { get; set; }
        public int ID { get; set; }

        public Student(string name, int id) 
        {
            this.StudentName = name;
            this.ID = id;
        }

        public Student() { }
    }
}
