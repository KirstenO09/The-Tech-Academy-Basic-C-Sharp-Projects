using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assigment
{
    interface IQuittable // Interface declaration for IQuittable
    {
        void Quit(Employee employee); // Method signature for quitting, accepts an Employee object as a parameter
    }
}
