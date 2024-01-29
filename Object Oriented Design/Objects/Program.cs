using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Object_Oriented_Design.Objects;

internal class Program
{
    static void Main()
    {
        Customer James = new Customer("James", "1234", "James@gmail.com");
        James.Email_Change("Ahaaniscool");
        James.Return_Detail();
    }
}
