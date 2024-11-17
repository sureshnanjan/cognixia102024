using System;
using System.Collections.Generic;

namespace KeywordLearning
{
    public class MethodCalling
    {
        // Pass-by-value method: Modifies the array, but does not affect the original
        static void ModifyArray(int[] array)
        {
            array[0] = 99;  // Modify the first element
            Console.WriteLine("Inside ModifyArray (Pass-by-Value): " + string.Join(", ", array));
        }

        // Pass-by-reference method: Modifies the list and affects the original
        static void ModifyList(ref List<int> list)
        {
            list.Add(100); // Add an item to the list
            Console.WriteLine("Inside ModifyList (Pass-by-Reference): " + string.Join(", ", list));
        }

        // Out parameters example: Returns multiple values using out parameters
        static void InitializeList(out List<string> stringList)
        {
            stringList = new List<string> { "Apple", "Banana", "Cherry" };
        }

        // In parameter example: Read-only parameter, can't modify the list
        static void DisplayList(in List<int> list)
        {
            Console.WriteLine("Inside DisplayList (Pass-by-ReadOnly): " + string.Join(", ", list));
        }

        public static void Execute()
        {
            // Pass-by-value example with array
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Before ModifyArray: " + string.Join(", ", numbers));
            ModifyArray(numbers);
            Console.WriteLine("After ModifyArray: " + string.Join(", ", numbers));

            // Pass-by-reference example with List
            List<int> numberList = new List<int> { 10, 20, 30 };
            Console.WriteLine("\nBefore ModifyList: " + string.Join(", ", numberList));
            ModifyList(ref numberList);
            Console.WriteLine("After ModifyList: " + string.Join(", ", numberList));

            // Out parameters example with List of strings
            Console.WriteLine("\n=== Out Parameters Example ===");
            InitializeList(out List<string> fruits);
            Console.WriteLine("Initialized List: " + string.Join(", ", fruits));

            // In parameters example with List of integers
            Console.WriteLine("\n=== In Parameters Example ===");
            List<int> immutableList = new List<int> { 5, 10, 15 };
            DisplayList(in immutableList);

            // Final summary
            Console.WriteLine("\n=== Summary ===");
            Console.WriteLine($"Numbers array after passing by value: {string.Join(", ", numbers)}");
            Console.WriteLine($"Number list after passing by reference: {string.Join(", ", numberList)}");
        }
    }
}
