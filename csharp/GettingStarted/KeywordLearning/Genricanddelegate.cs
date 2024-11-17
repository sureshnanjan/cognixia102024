﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Genricanddelegate
    {
        // Custom delegate: Takes 2 ints, 2 floats, returns a bool
        public delegate bool IntFloatBoolDelegate(int x, int y, float a, float b);
        // Custom delegate: Takes int, float, returns a string
        public delegate string IntFloatStringDelegate(int x, float y);
        /// <summary>
        /// Demonstrates the usage of custom delegates and equivalent Func delegates.
        /// </summary>
        public static void DemonstrateDelegates()
        {
            // Custom delegate: Takes 2 ints, 2 floats, returns a bool
            IntFloatBoolDelegate customBoolDelegate = (x, y, a, b) => (x + y) > (a + b);
            bool result1 = customBoolDelegate(10, 20, 5.5f, 3.5f);
            Console.WriteLine($"Custom Delegate (bool result): {result1}");

            // Custom delegate: Takes int, float, returns a string
            IntFloatStringDelegate customStringDelegate = (x, y) => $"Sum: {x + y}";
            string result2 = customStringDelegate(10, 5.5f);
            Console.WriteLine($"Custom Delegate (string result): {result2}");

            // Equivalent Func for Delegate 1
            Func<int, int, float, float, bool> funcBool = (x, y, a, b) => (x + y) < (a + b);
            bool result3 = funcBool(10, 20, 15.5f, 10.5f);
            Console.WriteLine($"Func (bool result): {result3}");

            // Equivalent Func for Delegate 2
            Func<int, float, string> funcString = (x, y) => $"Difference: {x - y}";
            string result4 = funcString(20, 5.5f);
            Console.WriteLine($"Func (string result): {result4}");
        }

        /// <summary>
        /// Demonstrates the usage of generics with constraints.
        /// </summary>
        public static void DemonstrateGenerics()
        {
            // Using a generic method to find the maximum of two values
            Console.WriteLine($"Max of 10 and 20: {FindMax(10, 20)}");
            Console.WriteLine($"Max of 5.5 and 3.3: {FindMax(5.5, 3.3)}");

            // Using a generic class
            var storage = new Storage<string>();
            storage.Add("Hello");
            storage.Add("World");
            Console.WriteLine($"Stored values: {string.Join(", ", storage.GetAll())}");
        }

        /// <summary>
        /// Generic method to find the maximum of two values.
        /// </summary>
        /// <typeparam name="T">A type that implements IComparable.</typeparam>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <returns>The larger of the two values.</returns>
        static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    /// <summary>
    /// Generic class to store a collection of items.
    /// </summary>
    /// <typeparam name="T">The type of items to store.</typeparam>
    public class Storage<T>
    {
        private readonly System.Collections.Generic.List<T> items = new System.Collections.Generic.List<T>();

        /// <summary>
        /// Adds an item to the storage.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(T item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Retrieves all items from the storage.
        /// </summary>
        /// <returns>A list of stored items.</returns>
        public System.Collections.Generic.List<T> GetAll()
        {
            return items;
        }
    }
}