using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Object_Oriented_Design.Objects
{
    public class Stewards : Employee
    {
        //Properties
        public string Airline { get; set; }
        public int CustomersServed { get; set; }

        public Stewards(string airline, int customersServed, int yearEmployed, string name, string accessControl) : base( yearEmployed,  name,  accessControl)
        {
            Airline = airline;
            CustomersServed = customersServed;
            
        }



        public override string Check_Employee()
        {
            {
                string result = ($"They were employed in {YearEmployed}, they are called {Name}, they have access to {AccessControl}, they work for {Airline} and they have worked there for {YearEmployed}");
                return result;
            }
        }

    }
}
