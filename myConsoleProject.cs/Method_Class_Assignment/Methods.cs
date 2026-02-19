using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    internal class Methods
    {
        //Create a method in the class that will take in two integers as parameters.
        public void Addition(int num1, int num2) {
            int sum = num1 + 2; //Add 2 to the first integer
            Console.WriteLine("Sum after adding 2 to the first number: " + sum); //Display the result of the first integer plus 2
            Console.WriteLine("The second integer is: " + num2); //Display the second integer
        }
    }
}
