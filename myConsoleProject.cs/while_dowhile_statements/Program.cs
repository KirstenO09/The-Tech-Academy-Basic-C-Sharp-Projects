using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_dowhile_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While and Do-While Statements Example");
            int count = 1;// Initialize count variable to 1
            Console.WriteLine("Using a while loop to count to 5:");// Inform user about while loop
            while (count <= 5)// While loop condition while count is less than or equal to 5
            {
                Console.WriteLine(count);// Print current count which equals 1
                count++;// Increment count by 1
            }

            count = 1;// Reset count variable to 1
            Console.WriteLine("Using a do-while loop to count to 5:");// Inform user about do-while loop
            do // Do-while loop
            {
                Console.WriteLine(count);// Print current count which equals 1
                count++;// Increment count by 1
            } while (count <= 5);// Do-while loop condition while count is less than or equal to 5
           
        }
    }
}
