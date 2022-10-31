using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Code { get; set; } //Module ID number
        public string Name { get; set; } //Module name
        public string Description { get; set; } //Module Description

        public LevelEnum Level { get; set; }
        public CreditEnum Credits { get; set; }

        public SortedSet<object> Members { get; set; } //List to store members in a module

        public Module(string code, string moduleName, string moduleDescription, int credits, object AdminPerson)  //MAIN CONSTRUCTOR
        {
            Code = code;
            Name = moduleName; //Parse in Module name from user input
            Description = moduleDescription; //Parse in Module Description from user input
            Members = new SortedSet<object>();
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
    }
}
