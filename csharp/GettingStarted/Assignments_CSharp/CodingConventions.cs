using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_CSharp
{
    /// <summary>
    /// Provides basic arithmetic operations like addition and subtraction.
    /// </summary>
    public class CodingConventions
    {
        /// <summary>
        /// Adds two integers and displays the result.
        /// </summary>
        /// <param name="a">The first integer to be added.</param>
        /// <param name="b">The second integer to be added.</param>
        public static void Add(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        }
        /// <summary>
        /// Subtracts the second integer from the first integer and displays the result.
        /// </summary>
        /// <param name="a">The integer from which another integer will be subtracted.</param>
        /// <param name="b">The integer to be subtracted from the first integer.</param>
        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"The difference between {a} and {b} is: {a - b}");
        }


    }
}
