using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Object_Oriented_Design
{
    public class Customer
    {
        //Properties
        public string UserName {  get; set; }
        public string Password { get; private set; }
        public string Email {  get; set; }
        public int ID { get; set; }

        //Constructor
        public Customer (string username, string password, string email)
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

        

    }
}
