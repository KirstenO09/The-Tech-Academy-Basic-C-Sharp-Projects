using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Assignment
{
    // Create a Person superclass with two properties: FirstName and LastName
    public class Person
    {
        public string FirstName { get; set; } // First name property
        public string LastName { get; set; } // Last name property

        public void SayName() // Method to output the full name
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // prints the full name to the console
        }
        

    }
}
