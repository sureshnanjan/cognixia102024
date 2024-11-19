using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_CSharp
{
    public  class GenericsAndDelegates
    {
        // Delegate 1: Takes 2 ints, 2 floats, and returns a bool
        public delegate bool MyFirstDelegate(int a, int b, float x, float y);

        // Delegate 2: Takes 1 int, 1 float, and returns a string
        public delegate string MySecondDelegate(int a, float x);

        // Method matching MyFirstDelegate signature
        public static bool CheckValues(int a, int b, float x, float y)
        {
            // Simple logic: returns true if sum of ints equals sum of floats
            return (a + b) == (x + y);
        }

        // Method matching MySecondDelegate signature
        public static string ConvertToString(int a, float x)
        {
            // Simple logic: returns a string combining both values
            return $"Int value: {a}, Float value: {x}";
        }

        // Using Func for the first delegate signature: Takes 2 ints, 2 floats, returns a bool
        public static void FuncDelegateExample()
        {
            // Func matching the first delegate signature
            Func<int, int, float, float, bool> func1 = CheckValues;

            bool result = func1(5, 10, 3.5f, 7.5f);  // Invoking the Func
            Console.WriteLine($"Func1 Result: {result}");
        }

        // Using Func for the second delegate signature: Takes 1 int, 1 float, returns a string
        public static void FuncDelegateExample2()
        {
            // Func matching the second delegate signature
            Func<int, float, string> func2 = ConvertToString;

            string result = func2(20, 15.5f);  // Invoking the Func
            Console.WriteLine($"Func2 Result: {result}");
        }

        // This method demonstrates assigning and invoking custom delegates
        public static void DelegateExample()
        {
            // Creating and assigning to custom delegate MyFirstDelegate
            MyFirstDelegate firstDelegate = new MyFirstDelegate(CheckValues);
            bool result1 = firstDelegate(5, 10, 3.5f, 7.5f);
            Console.WriteLine($"First Delegate Result: {result1}");  // True or False based on method logic

            // Creating and assigning to custom delegate MySecondDelegate
            MySecondDelegate secondDelegate = new MySecondDelegate(ConvertToString);
            string result2 = secondDelegate(20, 15.5f);
            Console.WriteLine($"Second Delegate Result: {result2}");
        }
    }
}
