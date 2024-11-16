using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    /// The Program class contains the entry point for the console application.
    /// It demonstrates the usage of documentation comments and basic program flow.
    public class Assignment1
    {
        // Constructor for Program class
        public Assignment1()
        {
            // This will be printed when an instance of Program is created
            Console.WriteLine("Program class instance created.");
        }

        /// This is the entry point for the application.
        public void Output()
        {
            // Display a welcome message to the user
            Console.WriteLine("Welcome to My Console Application!");

            // Ask the user for their name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // Greet the user with their name
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            // Instantiate Program class and run the program logic
            Assignment1 prog = new Assignment1();
            prog.Output();
        }
    }
}
