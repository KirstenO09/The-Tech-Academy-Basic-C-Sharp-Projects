using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Try_Catch_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is you age?: "); // Ask the user to enter a number
            //Display the year they were born
            try 
            {
                int age = Convert.ToInt32(Console.ReadLine()); // Read the user input

                // Get the current year
                int currentYear = DateTime.Now.Year;

                int yearBorn = currentYear - age; // Calculate the year they were born

                if (age <= 0) // If the user enters a negative number, throw an exception
                {
                    throw new ArgumentOutOfRangeException();
                }

                // Display the year the user was born
                Console.WriteLine("You were born in: " + yearBorn);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter a positive whole number for your age."); // If the user enters a negative number, display this message
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your system administrator."); // If any other error occurs, display this message
            }
            Console.ReadLine(); // Keep the console window open

        }
    }
}
