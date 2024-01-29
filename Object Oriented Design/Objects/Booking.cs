using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design.Objects
{
    public class Booking
    {
        //Properties
        public string Airport {  get; set; }
        public int Price { get; set; }


        //Constructor
        public Booking (string airport, int price)
        {
            Airport = airport;
            Price = price;

        }
    }
}
