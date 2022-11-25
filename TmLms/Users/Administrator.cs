namespace TmLms.Users
{
    public class Administrator
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Administrator(string name, int id) 
        {
            this.Name = name;
            this.ID = id;
        }
        public Administrator() { }
    }
}
