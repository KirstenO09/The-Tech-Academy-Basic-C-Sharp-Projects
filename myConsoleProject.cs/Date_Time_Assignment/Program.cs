using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is " + DateTime.Now); // Print the current date and time to the console
            Console.Write("Please enter a number: "); //Ask the user to enter a number

            //Prints to the console the exact time it will be in X hours, X being the number the user entered
            int hours = Convert.ToInt32(Console.ReadLine()); // Read the user input and convert it to an integer
            DateTime futureTime = DateTime.Now.AddHours(hours); // Calculate the future time by adding the number of hours to the current time
            Console.WriteLine("In {0} hours, it will be: {1}", hours, futureTime); // Print the future time to the console
            
        }
    }
}
