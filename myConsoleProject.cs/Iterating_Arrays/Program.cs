using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Iterating_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterating Through Arrays Assignment");

            //--Part One--
            Console.WriteLine("\n~Part One: Append User Input to Each Color in Array~");
            string[] stringArray = { "red", "blue", "green", "yellow", "purple", "orange" };// Create a one-dimensional array of strings

            Console.WriteLine("\nEnter some text to add to each color: ");// Prompt user for input
            string userInput = Console.ReadLine(); // Read user input

            //First Loop: Iterate through the array and append user input to each element
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += " " + userInput; // Append user input to each string in the array
            }

            //Second Loop: prints off each string in the array one at a time
            for (int j = 0; j < stringArray.Length; j++)
            {
                Console.WriteLine(stringArray[j]);// Print each modified string in the array 
            }

            //--Part Two--
            Console.WriteLine("\n~Part Two: Infinite Loop Example and Fix~");
            // Infinite loop example (commented out to prevent execution)
            // for (int k = 0; k >= 0; k++) // This creates an infinite loop because k will always be greater than or equal to 0
            // {
            //  Console.WriteLine("This is iteration number: " + k);
            // }

            // Fixed the infinite loop by changing the loop condition to ensure it will eventually terminate            
            Console.WriteLine("\nFixing the infinite loop:");
            for (int k = 0; k < 5; k++) // Changed the condition to k < 5 to ensure the loop terminates after 5 iterations
            {
                Console.WriteLine("This is iteration number: " + k); // Print the current iteration number
            }

            //--Part Three--
            Console.WriteLine("\n~Part Three: Different Loop Conditions~");
            for (int l = 0; l < 5; l++)
            {
                Console.WriteLine("\nLoop using < operator: " + l); // Print the current iteration number
            }

            for (int m = 0; m <= 5; m++)
            {
                Console.WriteLine("\nLoop using <= operator: " + m); // Print the current iteration number
            }


            //--Part Four--
            // A list of strings where each item in the list is unique.
            // Ask the user to input text to search for in the list.
            // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            
            Console.WriteLine("\n~Part Four: Search for User Input in List of Unique Strings~");
            List<string> uniqueStrings = new List<string>()
            {
                "apple",
                "dog",
                "purple",
                "hat",
                "ocean",
                "house"
            }; // Create a list of unique strings

            Console.WriteLine("\nEnter a string to search for in the list: "); // Prompt user for input
            string searchInput = Console.ReadLine(); // Read user input

            bool matchFound = false; // Flag to track if a match is found

            // Iterate through the list
            for (int n = 0; n < uniqueStrings.Count; n++)
            {
                if (uniqueStrings[n] == searchInput)
                {
                    Console.WriteLine("Match found at index: " + n); // Display index
                    matchFound = true; // Mark match as found
                    break; // Stop loop once match is found
                }
            }

            // After the loop finishes, check if no match was found
            if (!matchFound)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            //--Part Five--
            Console.WriteLine("\n~Part Five: Search for User Input in List that has two identical strings~");
            // Create a list of strings with duplicate values
            List<string> items = new List<string>()
            {
                "cat",
                "dog",
                "bird",
                "cat",
                "fish",
                "dog"
            };

            // Ask the user to enter text to search for
            Console.WriteLine("Enter text to search for:");
            string searchInput2 = Console.ReadLine();

            // Flag to track if any match is found
            bool match = false;

            // Loop through the list
            for (int i = 0; i < items.Count; i++)
            {
                // Check if current item matches user input
                if (items[i] == searchInput2)
                {
                    // Display the index of the matching item
                    Console.WriteLine("Match found at index: " + i);

                    // Set flag to true since a match was found
                    match = true;
                }
            }

            // If no matches were found, inform the user
            if (!match)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            //--Part Six--

            // Create a list of strings that contains duplicate values
            Console.WriteLine("\n~Part six: Unique List that contains Duplicate Values Example~");
            List<string> Letters = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "C"
            };

            // Create a new list to keep track of items that have already appeared
            List<string> seenLetters = new List<string>();

            // Loop through each item in the original list
            foreach (string letter in Letters)
            {
                // Check if the item has already appeared in the seenItems list
                if (seenLetters.Contains(letter))
                {
                    // If the item is already in seenItems, it is a duplicate
                    Console.WriteLine(letter + " - this item is a duplicate");
                }
                else
                {
                    // If the item is not in seenItems, it is unique
                    Console.WriteLine(letter + " - this item is unique");

                    // Add the item to seenItems so it can be tracked
                    seenLetters.Add(letter);
                }
            }

            // Keep the console window open so the user can read the output
            Console.ReadLine();
        }
    }
}
