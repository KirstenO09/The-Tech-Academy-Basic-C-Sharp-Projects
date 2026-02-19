using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    internal class Program
    {
        // Define a struct called Number
        // A struct is a value type that can hold related data
        public struct Number
        {
            // Property to store a decimal amount
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            // Create an object of type Number
            Number myNumber = new Number();

            // Assign a decimal value to the Amount property
            myNumber.Amount = 123.45m;

            // Print the amount to the console
            Console.WriteLine("The amount is: " + myNumber.Amount);

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
