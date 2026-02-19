using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:"); // Ask the user to enter a number
            String userInput = Console.ReadLine(); // Read the user input and store it in a variable
            
            File.WriteAllText(@"C:\Users\hf3984\VScode_Folders\Tech_Academy_C_and_NET\Basic_C#_Programs\myConsoleProject.cs\Input_Assignment\log.txt", userInput); // Write the user input to a text file
                        
            string text = File.ReadAllText(@"C:\Users\hf3984\VScode_Folders\Tech_Academy_C_and_NET\Basic_C#_Programs\myConsoleProject.cs\Input_Assignment\log.txt");
            Console.WriteLine("The number you entered was: " + text); // Read the text from the file and display it to the user

            Console.ReadLine(); // Wait for the user to press Enter before closing the console
        }
    }
}
