using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiply a number by 50
            Console.WriteLine("Enter a number: ");
            string num1 = Console.ReadLine();
            long product = Convert.ToInt32(num1) * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + product);

            //Add 25 to a number
            Console.WriteLine("\nEnter another number: ");
            string num2 = Console.ReadLine();
            long sum = Convert.ToInt32(num2) + 25;
            Console.WriteLine("Your number plus 25 is: " + sum);

            //Divide a number by 12.5
            Console.WriteLine("\nEnter a third number: ");
            string num3 = Console.ReadLine();
            double division = Convert.ToDouble(num3) / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + division);

            //Check if a number is greater than 50
            Console.WriteLine("\nEnter a fourth number: ");
            string num4 = Console.ReadLine();
            bool isGreaterThan50 = Convert.ToInt32(num4) > 50;
            Console.WriteLine("Is your number greater than 50? " + isGreaterThan50);

            //Divide a number by 7 and get the remainder
            Console.WriteLine("\nEnter a fifth number: ");
            string num5 = Console.ReadLine();
            int remainder = Convert.ToInt32(num5) % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder);
        }
    }
}
