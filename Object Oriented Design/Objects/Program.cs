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
        //Customer James = new ("James", "1234", "James@gmail.com");
        //James.Email_Change("Ahaaniscool");
        //James.Return_Detail();

        Pilot Ahaan = new("Everything", "Ahaan", 2006, 4, 30, "Boeing 505, EdgeLord400, Luxor Deluxe", new DateOnly(2007, 8, 8));
        //Console.WriteLine(Ahaan.Check_Employee());

        Pilot Ilias = new("Nothing", "Ilias", 2001, 11, 9, "RustBucket", new DateOnly(2011, 10, 19));
        Console.WriteLine(Ilias.Check_Employee());
    }
}
