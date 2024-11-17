using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Csharp
{
    /// <summary>
    /// The <see cref="CodingConventions"/> class contains the entry point for the application.
    /// This class demonstrates the use of coding conventions and string concatenation.
    /// </summary>
    public class CodingConventions
    {
        /// <summary>
        /// The main method that runs the application and demonstrates string concatenation.
        /// </summary>
        /// <remarks>
        /// This method demonstrates the use of <see cref="StringOperations.ConcatStrings"/>
        /// to concatenate two strings.
        /// </remarks>
        public static void NamingStandards()
        {
            Console.WriteLine("\nWelcome to the Coding Conventions Demo Application!");

            // Create an instance of the StringOperations class
            var stringOperations = new StringOperations();

            // Concatenate two strings using the ConcatStrings method
            string result = stringOperations.ConcatStrings("Coding", "Convention");

            // Output of concatenated result
            Console.WriteLine($"Concatenated String: {result}");
        }
    }

    /// <summary>
    /// Represents operations for string manipulation.
    /// </summary>
    public class StringOperations
    {
        /// <summary>
        /// Concatenates multiple strings using the + operator.
        /// </summary>
        /// <param name="parts">The strings to concatenate.</param>
        /// <returns>A single string with the concatenated result.</returns>
        public string ConcatStrings(params string[] parts)
        {
            string result = string.Empty;
            foreach (var part in parts)
            {
                result += part + " "; // Add a space after each part
            }
            return result.Trim(); // Remove the trailing space
        }
    }
}
