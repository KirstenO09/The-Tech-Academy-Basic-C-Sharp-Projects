using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assigment
{
    // Abstract base class that represents a generic person
    public abstract class Person
    {
        public string FirstName { get; set; } // First name property
        public string LastName { get; set; } // Last name property

        // Abstract method that must be implemented by derived classes
        public abstract void SayName(); // Method to output the full name
        
    }
}
