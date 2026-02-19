using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");

            // Read the user input from the console
            string userInput = Console.ReadLine();

            // Convert the input to an integer
            int number = Convert.ToInt32(userInput);

            // Call the void method that divides the number by 2
            Methods.DivideByTwo(number);

            // Call the method that uses an output parameter
            int outputResult;
            Methods.DivideByTwo(number, out outputResult);

            // Display the output parameter result
            Console.WriteLine("Using output parameter, the result is: " + outputResult);

            // Keep the console window open
            Console.ReadLine();

        }
    }
}
