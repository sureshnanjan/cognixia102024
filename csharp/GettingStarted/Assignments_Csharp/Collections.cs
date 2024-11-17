using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Csharp
{
    /// <summary>
    /// Provides CRUD (Create, Read, Update, Delete) operations on various collection types such as Dictionary, Stack, Queue, Set, and SortedSet.
    /// </summary>
    public class Collections
    {
        /// <summary>
        /// Demonstrates CRUD operations on a Dictionary.
        /// </summary>
        public static void DictionaryCRUD()
        {
            var dictionary = new Dictionary<int, string>();

            // Create
            dictionary.Add(1, "CSE");
            dictionary.Add(2, "ECE");
            dictionary.Add(3, "IT");

            // Read
            Console.WriteLine("\nDisplay Dictionary");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Update
            dictionary[2] = "EEE";
            Console.WriteLine("\nUpdated Dictionary:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Delete
            dictionary.Remove(1);
            Console.WriteLine("\nDictionary after Deletion:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }

        /// <summary>
        /// Demonstrates CRUD operations on a Stack.
        /// </summary>
        public static void StackCRUD()
        {
            var stack = new Stack<int>();

            // Create (Push)
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Read (Peek)
            Console.WriteLine("\nTop element in stack: " + stack.Peek());

            // Update (Pop and Push)
            stack.Pop();
            stack.Push(4);
            Console.WriteLine("\nStack after Update:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Delete (Pop)
            stack.Pop();
            Console.WriteLine("\nStack after Deletion:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Demonstrates CRUD operations on a Queue.
        /// </summary>
        public static void QueueCRUD()
        {
            var queue = new Queue<string>();

            // Create (Enqueue)
            queue.Enqueue("Alpha");
            queue.Enqueue("Beta");
            queue.Enqueue("Gamma");

            // Read (Peek)
            Console.WriteLine("\nFront element in queue: " + queue.Peek());

            // Update (Dequeue and Enqueue)
            queue.Dequeue();
            queue.Enqueue("Updated Gamma");
            Console.WriteLine("\nQueue after Update:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Delete (Dequeue)
            queue.Dequeue();
            Console.WriteLine("\nQueue after Deletion:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Demonstrates CRUD operations on a Set.
        /// </summary>
        public static void SetCRUD()
        {
            var set = new HashSet<string>();

            // Create
            set.Add("Cat");
            set.Add("Dog");
            set.Add("Elephant");

            // Read
            Console.WriteLine("\nOriginal Set:");
            foreach (var item in set) 
            { 
                Console.WriteLine(item);
            }

            // Update (Remove and Add)
            set.Remove("Dog");
            set.Add("Wolf");
            Console.WriteLine("\nSet after Update:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // Delete (Remove)
            set.Remove("Cat");
            Console.WriteLine("\nSet after Deletion:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Demonstrates CRUD operations on a SortedSet.
        /// </summary>
        public static void SortedSetCRUD()
        {
            var sortedSet = new SortedSet<string>();

            // Create
            sortedSet.Add("Banana");
            sortedSet.Add("Apple");
            sortedSet.Add("Cherry");

            // Read
            Console.WriteLine("\nOriginal SortedSet:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }

            // Update (Remove and Add)
            sortedSet.Remove("Banana");
            sortedSet.Add("Blueberry");
            Console.WriteLine("\nSortedSet after Update:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }

            // Delete (Remove)
            sortedSet.Remove("Apple");
            Console.WriteLine("\nSortedSet after Deletion:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
