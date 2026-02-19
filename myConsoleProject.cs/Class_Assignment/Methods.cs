using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    internal static class Methods
    {
        // Create a void method that divides the passed-in number by 2
        // and outputs the result to the screen
        public static void DivideByTwo(int data)
        {
            // Divide the number by 2
            int quotient = data / 2;

            // Display the result
            Console.WriteLine("Your number divided by 2 is: " + quotient);
        }

        // Create a method with an output parameter
        public static void DivideByTwo(int data, out int result)
        {
            // Divide the number by 2 and store it in the output parameter
            result = data / 2;
        }

        // Overload the method by changing the parameter list
        public static int DivideByTwo(double data)
        {
            // Divide the number by 2 and return the integer result
            return (int)(data / 2);
        }


    }
}
