using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading Example\n");
            Methods methods = new Methods(); // Create an instance of the Methods class
            int result1 = methods.Calculate(10); // Calls the Calculate method with an integer parameter
            Console.WriteLine("Calculated integer 10 plus 2: {0}", result1); // Output the result

            int result2 = methods.Calculate(10.5m); // Calls the Calculate method with a decimal parameter
            Console.WriteLine("Calculated decimal 10.5 divided by 2: {0}", result2); // Output the result

            int result3 = methods.Calculate("20"); // Calls the Calculate method with a string parameter
            Console.WriteLine("Calculated with string \"20\" multiplied by 2: {0}", result3); // Output the result

        }
    }
}
