namespace TmLms.Users
{
    public class Student
    {
        public string StudentName { get; set; }
        public int Id { get; set; }

        public Student(string name, int id) 
        {
            this.StudentName = name;
            this.Id = id;
        }
    }
}
