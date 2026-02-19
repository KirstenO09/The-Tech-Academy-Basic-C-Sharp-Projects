using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Student
    {
        // Create a const variable (cannot be changed once set)
        public const string SchoolName = "The Tech Academy";

        // Create a property to store the student's name
        public string Name { get; set; }

        // Create a property to store the student's age
        public int Age { get; set; }

        // FIRST constructor: accepts only a name
        // This constructor chains to the second constructor
        public Student(string name) : this(name, 0)
        {
            // No code needed here because constructor chaining
            // passes values to the second constructor
        }

        // SECOND constructor: accepts both name and age
        public Student(string name, int age)
        {
            // Assign the provided name to the Name property
            Name = name;

            // Assign the provided age to the Age property
            Age = age;
        }
    }
}
