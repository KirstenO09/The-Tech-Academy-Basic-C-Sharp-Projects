using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Create a new Employee object
            employee.FirstName = "Sample"; // Assign "Sample" to the FirstName superclass Person property
            employee.LastName = "Student"; // Assign "Student" to the LastName superclass Person property
            employee.SayName(); // Call the SayName() method from the Person superclass

        }
    }
}
