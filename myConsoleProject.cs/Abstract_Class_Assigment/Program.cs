using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instantiate an Employee object
            employee.FirstName = "Sample"; // assign first name
            employee.LastName = "Student"; // assign last name
            employee.SayName(); // call the SayName method
        }
    }
}
