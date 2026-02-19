using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a variable using the keyword "var"
            // The compiler determines the type (Student) automatically
            var student = new Student("Kirsten", 23);

            // Display the const variable
            Console.WriteLine("School: " + Student.SchoolName);

            // Display student information
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Student Age: " + student.Age);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
