using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Enums_Assignment
{
    // Enum that represents the days of the week
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Enter the current day of the week:");

            // Read the user's input as a string
            string input = Console.ReadLine();

            try
            {
                // Convert the user's input into a DaysOfWeek enum value
                DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true); // 'true' makes the parsing case-insensitive

                // Display the parsed enum value
                Console.WriteLine("Today is: " + today);
            }
            catch (Exception)
            {
                // Runs if the input is not a valid day of the week
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keeps the console window open
            Console.ReadLine();
        }
    }
}
