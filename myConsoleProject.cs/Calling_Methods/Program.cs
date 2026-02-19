using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Operations Program!");
            Methods methods = new Methods(); //Create an instance of the Methods class.

            //In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Enter a number to perform math operations on:"); //Prompt user for a number
            string number = Console.ReadLine(); //Get user input
            int userNumber = Convert.ToInt32(number); //Convert user input to an integer
            //Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
            int Add = methods.AddFive(userNumber); //Call AddFive method
            int subtract = methods.SubtractThree(userNumber); //Call SubtractThree method
            int multiply = methods.MultiplyByTwo(userNumber); //Call MultiplyByTwo method

            Console.WriteLine("Your number plus five is: " + Add); //Display result of AddFive
            Console.WriteLine("Your number minus three is: " + subtract); //Display result of SubtractThree
            Console.WriteLine("Your number multiplied by two is: " + multiply); //Display result of MultiplyByTwo

        }
    }
}
