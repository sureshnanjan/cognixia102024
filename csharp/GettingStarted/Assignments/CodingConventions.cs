using System;

namespace Assignments
{
    /// <summary>
    /// The <see cref="Program"/> class is the entry point of the application.
    /// </summary>
    public class CodingSatandard
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">An array of command-line arguments.</param>
        public static void NamingConvention()
        {
            Console.WriteLine("Welcome to the Documentation Demo Application!");
            // Create an instance of the SampleCalculator class
            var calculator = new SampleCalculator();
            int result = calculator.Add(5, 10);
            Console.WriteLine($"5 + 10 = {result}");
        }
    }

    /// <summary>
    /// Represents a simple calculator with basic arithmetic operations.
    /// </summary>
    public class SampleCalculator
    {
        /// <summary>
        /// Adds two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts one integer from another.
        /// </summary>
        /// <param name="a">The integer to be subtracted from.</param>
        /// <param name="b">The integer to subtract.</param>
        /// <returns>The result of subtracting <paramref name="b"/> from <paramref name="a"/>.</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
