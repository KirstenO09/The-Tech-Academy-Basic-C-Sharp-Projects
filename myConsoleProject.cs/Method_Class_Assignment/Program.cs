using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods(); // Create an instance of the Methods class

            //Call the method in the class, passing in two numbers
            methods.Addition(5, 10);
            
            //Call the method in the class, specifying the parameters by name.            
            methods.Addition(num1: 20, num2: 15);

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
