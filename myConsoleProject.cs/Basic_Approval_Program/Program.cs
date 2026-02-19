using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Approval_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Approval Program"); // Display the title of the application
            Console.WriteLine("What is your age?"); // Ask for the user's age
            string ageInput = Console.ReadLine(); // Get the user's age input
            int age = Convert.ToInt32(ageInput); // Convert the input to an integer
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\""); // Ask if the user has had a DUI
            bool hasDUI = Convert.ToBoolean(Console.ReadLine()); // Get the user's response and convert it to a boolean
            Console.WriteLine("How many speeding tickets do you have?"); // Ask for the number of speeding tickets
            string ticketsInput = Console.ReadLine(); // Get the user's input
            int speedingTickets = Convert.ToInt32(ticketsInput); // Convert the input to an integer
            // Determine approval based on criteria
            bool isApproved = (age > 15) && (!hasDUI) && (speedingTickets <= 3);
            Console.WriteLine("Qualified to get insurance: " + isApproved); // Display whether the user is qualified for insurance
        }
    }
}
