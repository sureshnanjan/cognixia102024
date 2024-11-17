using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Csharp
{
    // Delegate 1: Takes two ints and two floats, returns bool
    public delegate bool CalculateBool(int a, int b, float x, float y);

    // Delegate 2: Takes an int and a float, returns string
    public delegate string CalculateString(int a, float b);

    /// <summary>
    /// A generic calculator class that performs addition on numeric types.
    /// The type parameter <typeparamref name="T"/> must be a value type (struct).
    /// </summary>
    public class Calculator<T> where T : struct
    {
        /// <summary>
        /// Adds two values of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="a">The first value to add.</param>
        /// <param name="b">The second value to add.</param>
        /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
        private T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        /// <summary>
        /// Demonstrates the usage of the <see cref="Calculator{T}"/> class with different numeric types such as int, double and float.
        /// </summary>
        public static void GenericsCall()
        {
            var intCalculator = new Calculator<int>();
            Console.WriteLine(intCalculator.Add(5, 10)); // Output: 15
            var doubleCalculator = new Calculator<double>();
            Console.WriteLine(doubleCalculator.Add(5.5, 10.5)); // Output: 16.0
            var floatCalculator = new Calculator<float>();
            Console.WriteLine(doubleCalculator.Add(5.55f, 10.55f)); // Output:16.1
        }
    }

    /// <summary>
    /// A class to demonstrate the usage of delegates in C#.
    /// </summary>
    public class Delegates
    {
        /// <summary>
        /// Method to use the <see cref="CalculateBool"/> and <see cref="CalculateString"/> delegates.
        /// </summary>
        public static void DelegateCall()
        {
            // Delegate 1: Example method for CalculateBool delegate
            CalculateBool boolDelegate = new CalculateBool(CompareSum);
            bool res1 = boolDelegate(5, 3, 2.5f, 1.5f);  // Should return true if sum of ints > sum of floats
            Console.WriteLine($"Delegate 1 result: {res1}");

            // Delegate 2: Example method for CalculateString delegate
            CalculateString stringDelegate = new CalculateString(FormatOutput);
            string res2 = stringDelegate(5, 3.5f);
            Console.WriteLine($"Delegate 2 result: {res2}");
        }

        // Method that matches the first delegate (bool return)
        private static bool CompareSum(int a, int b, float x, float y)
        {
            int sumInts = a + b;
            float sumFloats = x + y;
            return sumInts > sumFloats; // Returns true if sum of ints is greater than sum of floats
        }

        // Method that matches the second delegate (string return)
        private static string FormatOutput(int a, float b)
        {
            return $"The value of int is {a} and the value of float is {b}"; //returns the string output
        }
    }

}
