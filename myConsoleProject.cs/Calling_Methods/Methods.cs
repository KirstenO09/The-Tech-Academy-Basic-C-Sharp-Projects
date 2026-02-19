using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    internal class Methods
    {
        //Create three methods, each of which will take one integer parameter in and return an integer.
        //The methods should do some math operation on the received parameter. 

        //First method adds five to the input number
        public int AddFive(int number)
        {
            return number + 5; //Return the result
        }

        //Second method subtracts three from the input number
        public int SubtractThree(int number)
        {
            return number - 3;//Return the result
        }

        //Third method multiplies the input number by two
        public int MultiplyByTwo(int number)
        {
            return number * 2; //Return the result
        }
    }
}
