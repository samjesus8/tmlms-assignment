using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    public class Administrator
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Administrator(string name) 
        {
            this.Name = name;

            var random = new Random();
            ID = random.Next(0, 100);
        }
    }
}
