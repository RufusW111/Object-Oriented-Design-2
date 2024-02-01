using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Object_Oriented_Design.Objects
{
    public class Customer
    {

        //Properties
        public string UserName { get; set; }
        public string Password { get; private set; }
        public string Email { get; set; }
        public int ID { get; set; }

        private List<Booking> _bookings = new();

        //Constructor
        public Customer(string username, string password, string email)
        {
            UserName = username;
            Password = password;
            Email = email;
            Random random = new();
            ID = random.Next(1, 1000);
        }
        //Method
        public void Email_Change(string newEmail)
        {
            Email = newEmail;
        }

        public string Return_Detail()
        {
            string details = $"The username is {UserName}, the email is {Email} and the UserID is {ID}";
            Console.WriteLine(details);
            return details;
        }

        public List<Booking> Add_Booking( string Airport, int Price, string Title)
        {
            Booking booking = new(Airport, Price, Title );
            _bookings.Add( booking );
            return _bookings;
        }

        public void Check_Bookings()
        {
            foreach (Booking booking in _bookings)
            {
                Console.Write( booking + "," );
            }
        }





    }
}
