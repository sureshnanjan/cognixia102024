
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyaAssignment
    {
         class Delegate
        {
            // Method matching Delegate 1: Takes 2 int, 2 float and returns a bool
            public static bool CompareNumbers(int a, int b, float x, float y)
            {
                // Example logic: Check if the sum of integers is greater than the sum of floats
                return (a + b) > (x + y);
            }

            // Method matching Delegate 2: Takes int, float and returns a string
            public static string NumberToString(int a, float b)
            {
                // Example logic: Return a formatted string
                return $"Integer: {a}, Float: {b}";
            }

            public static void Main(string[] args)
            {
                // Delegate 1: Takes 2 ints, 2 floats, and returns a bool
                Func<int, int, float, float, bool> delegate1 = CompareNumbers;
                bool result = delegate1(5, 10, 3.5f, 2.5f);  // Call the delegate
                Console.WriteLine($"CompareNumbers result: {result}");  // Output: CompareNumbers result: True

                // Delegate 2: Takes int, float, and returns a string
                Func<int, float, string> delegate2 = NumberToString;
                string formattedResult = delegate2(7, 5.3f);  // Call the delegate
                Console.WriteLine(formattedResult);  // Output: Integer: 7, Float: 5.3
            }
        }
    }
