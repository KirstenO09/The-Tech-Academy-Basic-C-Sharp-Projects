using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the title of the program
            Console.WriteLine("Array and Lists Examples Program");

            /* -------------------------------------------------
               ARRAY OF STRINGS
            ------------------------------------------------- */

            // Create a one-dimensional array of strings
            string[] stringArray = { "apple", "orange", "banana", "grape", "watermelon", "lemon" };

            // Ask the user to select an index
            Console.WriteLine("\n~Select an index from an array of strings~");
            
            Console.WriteLine("Enter an index number: ");

            // Read user input and convert it to an integer
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index exists in the array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the value at the selected index
                Console.WriteLine("Value at index " + stringIndex + ": " + stringArray[stringIndex]);
            }
            else
            {
                // Display error message if index does not exist
                Console.WriteLine("That index does not exist in the string array.");
            }

            /* -------------------------------------------------
               ARRAY OF INTEGERS
            ------------------------------------------------- */

            // Create a one-dimensional array of integers
            int[] intArray = { 1, 3, 7, 2, 8, 5, 9, 6, 4, 10 };

            // Ask the user to select an index
            Console.WriteLine("\n~Select an index from an array of integers~");
            Console.WriteLine("Enter an index number: ");

            // Read user input and convert it to an integer
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index exists in the array
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the value at the selected index
                Console.WriteLine("Value at index " + intIndex + ": " + intArray[intIndex]);
            }
            else
            {
                // Display error message if index does not exist
                Console.WriteLine("That index does not exist in the integer array.");
            }

            /* -------------------------------------------------
               LIST OF STRINGS
            ------------------------------------------------- */

            // Create a list of strings
            List<string> stringList = new List<string>()
            {
                "red",
                "blue",
                "green",
                "yellow",
                "purple"
            };

            // Ask the user to select an index
            Console.WriteLine("\n~Select an index from a list of strings~");
            Console.WriteLine("Enter an index number: ");

            // Read user input and convert it to an integer
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index exists in the list
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the value at the selected index
                Console.WriteLine("Value at index " + listIndex + ": " + stringList[listIndex]);
            }
            else
            {
                // Display error message if index does not exist
                Console.WriteLine("That index does not exist in the list.");
            }

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();




        }
    }
}
