
/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
 
  http://www.apache.org/licenses/LICENSE-2.0
 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class GenricAndDelegate
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
            IntFloatBoolDelegate customBoolDelegate = (x, y, a, b) => (x - y) > (a * b);
            bool result1 = customBoolDelegate(30, 10, 2.5f, 3.2f);  // Different values for comparison
            Console.WriteLine($"Custom Delegate (bool result): {result1}");

            // Custom delegate: Takes int, float, returns a string
            IntFloatStringDelegate customStringDelegate = (x, y) => $"Product: {x * y}";
            string result2 = customStringDelegate(12, 8.5f);  // Different input values for multiplication
            Console.WriteLine($"Custom Delegate (string result): {result2}");

            // Equivalent Func for Delegate 1
            Func<int, int, float, float, bool> funcBool = (x, y, a, b) => (x + y) < (a - b);  // Changed the comparison logic
            bool result3 = funcBool(15, 25, 18.5f, 10.0f);  // New comparison with different values
            Console.WriteLine($"Func (bool result): {result3}");

            // Equivalent Func for Delegate 2
            Func<int, float, string> funcString = (x, y) => $"Quotient: {x / y}";
            string result4 = funcString(50, 7.5f);  // Division with different input values
            Console.WriteLine($"Func (string result): {result4}");
        }

        /// <summary>
        /// Demonstrates the usage of generics with constraints.
        /// </summary>
        public static void DemonstrateGenerics()
        {
            // Using a generic method to find the maximum of two values (using different inputs)
            Console.WriteLine($"Max of 50 and 30: {FindMax(50, 30)}");  // Larger integer input
            Console.WriteLine($"Max of 3.75 and 9.99: {FindMax(3.75, 9.99)}");  // Larger floating-point input

            // Using a generic class to store string values
            var storage = new Storage<int>();  // Using a generic class with different type (int)
            storage.Add(5);
            storage.Add(15);
            storage.Add(10);
            Console.WriteLine($"Stored integer values: {string.Join(", ", storage.GetAll())}");  // Integer storage

            // Using the generic class with another type (string)
            var stringStorage = new Storage<string>();  // Using a generic class with string type
            stringStorage.Add("Apple");
            stringStorage.Add("Banana");
            stringStorage.Add("Orange");
            Console.WriteLine($"Stored string values: {string.Join(", ", stringStorage.GetAll())}");  // String storage
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
