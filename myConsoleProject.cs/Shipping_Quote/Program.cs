using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below."); // Display welcome message
            Console.WriteLine("Please enter the package weight:"); // Prompt user for package weight
            string weightInput = Console.ReadLine(); // Read user input for weight
            int weight = Convert.ToInt32(weightInput); // Convert weight input to integer
            if (weight > 50) // Check if weight exceeds limit
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); // Display message for overweight package
            }
            else
            {
                Console.WriteLine("Please enter the package width:"); // Prompt user for package width
                string widthInput = Console.ReadLine(); // Read user input for width
                int width = Convert.ToInt32(widthInput); // Convert width input to integer
                Console.WriteLine("Please enter the package height:"); // Prompt user for package height
                string heightInput = Console.ReadLine(); // Read user input for height
                int height = Convert.ToInt32(heightInput); // Convert height input to integer
                Console.WriteLine("Please enter the package length:"); // Prompt user for package length
                string lengthInput = Console.ReadLine(); // Read user input for length
                int length = Convert.ToInt32(lengthInput); // Convert length input to integer
                int dimensionSum = width + height + length; // Calculate sum of dimensions
                if (dimensionSum > 50) // Check if dimension sum exceeds limit
                {
                    Console.WriteLine("Package too big to be shipped via Package Express."); // Display message for oversized package
                }
                else
                {
                    double dimensionProduct = width * height * length; // Calculate product of dimensions
                    double quote = (dimensionProduct * weight) / 100.0; // Calculate shipping quote
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00")); // Display shipping quote formatted to two decimal places
                    Console.WriteLine("Thank you!"); // Thank the user
                }
            }
        }
    }
}
