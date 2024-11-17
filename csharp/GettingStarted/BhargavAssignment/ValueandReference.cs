using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajProject
{
    public class ValueandReference
    {
        // Method demonstrating Pass by Value
        static void squareVal(int valParameter)
        {
            valParameter *= valParameter;  // Squaring the value (Does not affect the original value)
        }

        // Method demonstrating Pass by Reference
        static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;  // Squaring the value (Affects the original value)
        }

        public static void Main(string[] args)
        {
            // Demonstrating Pass by Value
            int value = 5;
            Console.WriteLine($"Original value before squareVal: {value}");
            squareVal(value); // Passing by value, original value won't change
            Console.WriteLine($"Value after squareVal: {value}");

            // Demonstrating Pass by Reference
            int referenceValue = 5;
            Console.WriteLine($"\nOriginal referenceValue before squareRef: {referenceValue}");
            squareRef(ref referenceValue); // Passing by reference, original value will change
            Console.WriteLine($"referenceValue after squareRef: {referenceValue}");
        }
    }
}
