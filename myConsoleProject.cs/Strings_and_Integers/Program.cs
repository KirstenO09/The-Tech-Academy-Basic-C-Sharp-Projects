using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>()
            {27, 42, 53, 45, 65, 46, 37, 18, 39, 21}; // A list of integers

            Console.WriteLine("Enter a number to divide each number in the list by: ");
            string userInput = Console.ReadLine(); // Prompt user for input
            int userNumber = Convert.ToInt32(userInput); // Convert user input to integer

            try // Try block to handle potential exceptions
            {
                for (int i = 0; i < intList.Count; i++) // Iterate through the list of integers
                {
                    double quotient = Convert.ToDouble(intList[i]) / userNumber; // Divide each number in the list by the user's number
                    Console.WriteLine("Number in the list divided by your number is: " + quotient);// Print the index and corresponding integer
                }
            }
            catch (FormatException ex) // Catch block for format exceptions
            {
                Console.WriteLine("An error occurred. Please type a whole number: " + ex.Message);// Handle division by zero or other exceptions
            }
            catch (DivideByZeroException ex) // Catch block for division by zero exceptions
            {
                Console.WriteLine("An error occurred. Please do not divide by zero: " + ex.Message); // Handle division by zero specifically
            }Console.ReadLine();
        }
    }
}
