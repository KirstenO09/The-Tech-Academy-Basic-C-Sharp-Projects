using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods(); // Create an instance of the Methods class
            
            Console.WriteLine("Enter the first number: "); // asks user to enter the first number
            string userInput1 = Console.ReadLine(); // reads user input
            int userNumber1 = Convert.ToInt32(userInput1); //Convert user input to an integer

            Console.WriteLine("Enter the second number (press Enter to skip): "); // asks user to enter the second number or skip
            string userInput2 = Console.ReadLine();

            int result; // initializes the result variable

            // Check if the user entered a second number
            if (userInput2 == "") // if the user input for the second number is blank 
            {
                // Call the method with only one argument
                result = methods.AddNum(userNumber1);
            }
            else // otherwise, if the user input for the second number is not blank then add the two numbers entered by the user
            {
                // Convert the second input to an integer
                int userNumber2 = Convert.ToInt32(userInput2);

                // Call the method with both arguments
                result = methods.AddNum(userNumber1, userNumber2);
            }

            // Display the result to the user
            Console.WriteLine("The sum of the numbers is: " + result);

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
