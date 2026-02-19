using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.Id = 1;

            // Create the second Employee object and assign values
            Employee employee2 = new Employee();
            employee2.FirstName = "Test";
            employee2.LastName = "User";
            employee2.Id = 1;

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display the comparison result
            Console.WriteLine("Are the two employees equal? " + areEqual);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
