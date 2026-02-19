using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Methods
    {
        //Create a method in the class that will take in an integer, create a math operation for it, then return the answer as an integer.
        public int Calculate(int number) //Take in an integer parameter
        {
            return number + 2; //Add 2 to the input number and return the result
        }


        //Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.       
        public int Calculate(decimal number) //Take in a decimal parameter
        {
            int numInt = Convert.ToInt32(number); //Convert decimal to integer            
            int divide = numInt / 2; //Divide the integer by 2
            return (divide); //Return the result
        }

        //Add a third method to the class with the same name that will take in a string, create a different math operation for it, then return the answer as an integer.
        public int Calculate(string number) //Take in a string parameter
        {
            int numInt = Convert.ToInt32(number); //Convert string to integer   
            int multiply = numInt * 2; //Multiply the integer by 2
            return (multiply); //Return the result
        }
    }
}
