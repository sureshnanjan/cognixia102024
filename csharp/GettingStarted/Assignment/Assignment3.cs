using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Assignment3
    {
        // Delegate Declaration for a method that takes 2 ints, 2 floats and returns a bool
        public delegate bool MyBoolDelegate(int a, int b, float x, float y);

        // Delegate Declaration for a method that takes an int, a float and returns a string
        public delegate string MyStringDelegate(int a, float b);

        static bool CompareValues(int a, int b, float x, float y)
        {
            Console.WriteLine($"Comparing: {a}, {b}, {x}, {y}");
            return a + b == x + y; // Return true if sum of ints equals sum of floats
        }

        // Method matching MyStringDelegate (takes 1 int, 1 float, returns a string)
        static string FormatValues(int a, float b)
        {
            return $"The values are: {a} and {b}";
        }

        public void Output(string[] args)
        {
            // Delegate that takes 2 ints, 2 floats and returns a bool
            MyBoolDelegate myBoolDelegate = new MyBoolDelegate(CompareValues);
            bool result = myBoolDelegate(5, 10, 7.5f, 7.5f); // Passing values
            Console.WriteLine($"Comparison result: {result}");

            // Delegate that takes 1 int, 1 float and returns a string
            MyStringDelegate myStringDelegate = new MyStringDelegate(FormatValues);
            string formattedString = myStringDelegate(42, 3.14f); // Passing values
            Console.WriteLine(formattedString);

            // Using Func<> for similar delegate assignments:

            // Func delegate for CompareValues method (bool return type)
            Func<int, int, float, float, bool> compareFunc = CompareValues;
            result = compareFunc(1, 2, 3.0f, 3.0f); // Calling via Func
            Console.WriteLine($"Comparison result via Func: {result}");

            // Func delegate for FormatValues method (string return type)
            Func<int, float, string> formatFunc = FormatValues;
            formattedString = formatFunc(7, 1.618f); // Calling via Func
            Console.WriteLine(formattedString);
        }
    }
}
