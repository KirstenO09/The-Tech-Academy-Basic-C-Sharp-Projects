using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of things.
            Employee<string> supplies = new Employee<string>(); // Create an Employee object with string type
            supplies.things = new List<string>() { "Laptop", "Notebook", "Pen", "Mouse", "Monitor" }; // Assign a list of strings to the Things property
            
            Console.WriteLine("Employee Supplies:"); // Print a header for clarity
            foreach (var item in supplies.things) // Iterate through the Things list and print each item
            {
                Console.WriteLine(item); // Output each item to the console
            }


            Console.WriteLine("\nEmployee Desk Numbers:"); // Print a header for clarity
            Employee<int> desknum = new Employee<int>(); // Create an Employee object with int type
            desknum.things = new List<int>() { 1117, 1112, 1113, 1114, 1115 }; // Assign a list of integers to the Things property

            foreach (var item in desknum.things) // Iterate through the Things list and print each item
            {
                Console.WriteLine(item); // Output each item to the console
            }

        }
    }
}
