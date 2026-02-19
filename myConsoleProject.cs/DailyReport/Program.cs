using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); // Display the name of the bootcamp
            Console.WriteLine("Student Daily Report"); // Display the title of the application

            Console.WriteLine("What is your name?"); // Ask for the user's name
            string StudentName = Console.ReadLine(); // Get the user's name

            Console.WriteLine("What course are you on?"); // Ask for the course name
            string CourseName = Console.ReadLine(); // Get the course name

            Console.WriteLine("What page number?"); // Ask for the page number
            string PageNum = Console.ReadLine(); // Get the page number

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\""); // Ask if the user needs help
            bool help = Convert.ToBoolean(Console.ReadLine()); // Get the user's response and convert it to a boolean

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); // Ask for positive experiences
            string experience = Console.ReadLine(); // Get the user's response

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); // Ask for additional feedback
            string feedback = Console.ReadLine(); // Get the user's response

            Console.WriteLine("How many hours did you study today?"); // Ask for the number of study hours
            string StudyHours = Console.ReadLine(); // Get the user's response

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); // Thanks the user

        }
    }
}
