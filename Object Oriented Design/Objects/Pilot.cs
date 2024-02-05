using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design.Objects
{
    public class Pilot : Employee
    {
        //Proprties
        public int FlyingLevel { get; set; }
        public int TimeInAir {  get; set; }
        public string PlanesFlown { get; set; }

        public DateOnly LastCheckUp {  get; set; }


        //Constructor

        public Pilot(string name, string accessControl, int yearEmployed, int flyingLevel, int timeInAir, string planesFlown, DateOnly lastCheckUp) : base (yearEmployed, accessControl, name   )
        {
            FlyingLevel = flyingLevel;
            TimeInAir = timeInAir;
            PlanesFlown = planesFlown;
            LastCheckUp = lastCheckUp;

        }




        public override string Check_Employee()
        {
            string result = ($"They were employed in {YearEmployed}, they are called {Name}, they have access to {AccessControl}, they have achieved flying level {FlyingLevel}, they have flown {PlanesFlown}, they have spent {TimeInAir} hours in the air and their last checkup was on {LastCheckUp}");

            return result;
        }


    }
}
