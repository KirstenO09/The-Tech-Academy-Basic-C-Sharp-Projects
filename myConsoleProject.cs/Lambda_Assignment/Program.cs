using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 Employee objects
            // At least two employees have the first name "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Brandon", LastName = "Lee" },
                new Employee { Id = 3, FirstName = "Kiara", LastName = "Brown" },
                new Employee { Id = 4, FirstName = "Jessica", LastName = "White" },
                new Employee { Id = 5, FirstName = "Jacob", LastName = "Miller" },
                new Employee { Id = 6, FirstName = "Kayla", LastName = "Wilson" },
                new Employee { Id = 7, FirstName = "Michael", LastName = "Davis" },
                new Employee { Id = 8, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 9, FirstName = "Brianna", LastName = "Taylor" },
                new Employee { Id = 10, FirstName = "Chris", LastName = "Anderson" }
            };

            // -------------------------------
            // FOREACH VERSION
            // -------------------------------

            // Create a new list to store employees named "Joe"
            List<Employee> joeEmployeesForeach = new List<Employee>();

            // Loop through each employee in the list
            foreach (Employee employee in employees)
            {
                // Check the FirstName property of the employee
                if (employee.FirstName == "Joe")
                {
                    // Add matching employees to the new list
                    joeEmployeesForeach.Add(employee);
                }
            }

            // Display employees named Joe (foreach)
            Console.WriteLine("Employees named Joe (using foreach):");
            foreach (Employee joe in joeEmployeesForeach)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} (ID: {joe.Id})");
            }

            // -------------------------------
            // LAMBDA VERSION (First Name = Joe)
            // -------------------------------

            // Use a lambda expression to filter employees named "Joe"
            List<Employee> joeEmployeesLambda =
                employees.Where(e => e.FirstName == "Joe").ToList();

            // Display employees named Joe (lambda)
            Console.WriteLine("\nEmployees named Joe (using lambda):");
            foreach (Employee joe in joeEmployeesLambda)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} (ID: {joe.Id})");
            }

            // -------------------------------
            // LAMBDA VERSION (Id > 5)
            // -------------------------------

            // Use a lambda expression to find employees with Id greater than 5
            List<Employee> idGreaterThanFive =
                employees.Where(e => e.Id > 5).ToList();

            // Display employees with Id > 5
            Console.WriteLine("\nEmployees with ID greater than 5:");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} (ID: {emp.Id})");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
