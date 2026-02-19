using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    internal class Employee
    {
        public string FirstName { get; set; } // First name property
        public string LastName { get; set; } // Last name property
        public int Id { get; set; } // ID property


        // Overload == operator to compare Employee Id values
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If either employee is null, they are not equal
            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            // Compare employees by their Id property
            return emp1.Id == emp2.Id;
        }

        // Overload != operator (required pair)
        public static bool operator !=(Employee emp1, Employee emp2) 
        {
            return emp1.Id != emp2.Id; 
        }

        // Override Equals to match == behavior 
        public override bool Equals(object obj) 
        {
            if (obj is Employee employee)
            {
                return this.Id == employee.Id;
            }
            return false;
        }

        // Override GetHashCode because Equals was overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
