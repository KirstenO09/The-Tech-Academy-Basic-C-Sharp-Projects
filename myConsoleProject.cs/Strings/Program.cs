using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings Example Program"); // Display the title of the application

            Console.WriteLine("\n~Concatenates two strings~");
            string firstName = "John"; // Initialize first name
            string lastName = "Doe"; // Initialize last name
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            string fullName = firstName + " " + lastName; // Concatenate first and last name
            Console.WriteLine("Full Name: " + fullName); // Display full name
            
            Console.WriteLine("\n~Converts string to uppercase~"); // Inform user about uppercase conversion
            Console.WriteLine("Uppercase Full Name: " + fullName.ToUpper()); // Display full name in uppercase
            
            Console.WriteLine("\n~Creates a Stringbuilder and builds a paragraph of text one sentence at a time~"); // Inform user about StringBuilder
            StringBuilder paragraph = new StringBuilder(); // Initialize StringBuilder
            paragraph.Append("This is the first sentence. "); // Append first sentence
            Console.WriteLine(paragraph);
            paragraph.Append("Here is the second sentence. "); // Append second sentence
            Console.WriteLine(paragraph);
            paragraph.Append("Finally, this is the third sentence."); // Append third sentence
            Console.WriteLine(paragraph);

        }
    }
}
