using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Methods
    {
        public int AddNum(int num1, int num2 = 1) //Method that takes in one or two integers, with the second integer having a default value of 1
        { 
            int Addition = num1 + num2; //Add the two numbers together
            return (Addition); //Return the result
        }
    }
}
