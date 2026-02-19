using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); // Display the title of the application
            
            Console.WriteLine("Person 1"); // prints "Person 1" to screen
            Console.WriteLine("Enter hourly Rate: "); // asks user to enter their hourly rate for person 1
            string hourlyrate1 = Console.ReadLine(); // reads user input and assigns it to string variable
            Console.WriteLine("Enter hours worked per week: "); // asks user to enter hours worked per week for person 1
            string hoursworked1 = Console.ReadLine(); // reads user input and assigns it to string variable
            double salary1 = Convert.ToDouble(hourlyrate1) * Convert.ToDouble(hoursworked1); // converts the string inputs to double and calculates the salary
            

            Console.WriteLine("Person 2"); // prints "Person 1" to screen
            Console.WriteLine("Enter hourly Rate: "); // asks user to enter their hourly rate for person 1
            string hourlyrate2 = Console.ReadLine(); // reads user input and assigns it to string variable
            Console.WriteLine("Enter hours worked per week: "); // asks user to enter hours worked per week for person 1
            string hoursworked2 = Console.ReadLine(); // reads user input and assigns it to string variable
            double salary2 = Convert.ToDouble(hourlyrate2) * Convert.ToDouble(hoursworked2); // converts the string inputs to double and calculates the salary

            Console.WriteLine("Annual salary of Person 1: "); 
            Console.WriteLine(salary1); // prints the calculated annual salary of person 1
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(salary2); // prints the calculated annual salary of person 2

            Console.WriteLine("Does Person 1 make more money than Person 2?: "); 
            bool makemore = Convert.ToInt32(salary1) > Convert.ToInt32(salary2); // uses a boolean variable to compare if person 1 salary is greater than person 2 salary
            Console.WriteLine(makemore); // prints the answer (True or False) to the screen

        }
    }
}
