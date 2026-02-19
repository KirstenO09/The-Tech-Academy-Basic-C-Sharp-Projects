using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assigment
{
    // Employee class inherits from the abstract Person class
    public class Employee : Person, IQuittable
    {
        // Overrides the abstract SayName method from the Person class
        public override void SayName()
        {
            // Displays the employee's full name to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Implementation of the Quit method from the IQuittable interface
        public void Quit(Employee employee) // Accepts an Employee object as a parameter
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit."); // Displays a message indicating the employee has quit
        }
    }
}
