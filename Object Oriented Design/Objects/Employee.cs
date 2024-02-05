using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design.Objects
{
    public class Employee
    {
        //Proprties
        public int YearEmployed { get; set; }
        public string Name { get; set; }
        public string AccessControl { get; set; }

        //Constructor
        public Employee(int yearEmployed, string name, string accessControl)
        {
            YearEmployed = yearEmployed;
            Name = name;
            AccessControl = accessControl;
        
        }


        public virtual string Check_Employee()
        {
            string result = ($"They were employed in {YearEmployed}, they are called {Name} and they have access to {AccessControl}");
            return result;
        }
    }
}
