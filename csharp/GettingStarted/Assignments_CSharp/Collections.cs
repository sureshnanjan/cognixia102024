using System;
using System.Collections.Generic;

namespace Assignments_CSharp
{
    public class Collections
    {
        // Dictionary CRUD Operations
        public static void DictionaryOperations()
        {
            Console.WriteLine("Dictionary Operations:");

            // Create
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary[3] = "Cherry"; // Add new key-value pair

            // Read
            Console.WriteLine($"Value for key 2: {dictionary[2]}"); // "Banana"

            // Update
            dictionary[2] = "Blueberry"; // Update value for key 2
            Console.WriteLine($"Updated value for key 2: {dictionary[2]}"); // "Blueberry"

            // Delete
            dictionary.Remove(1); // Remove key-value pair where key = 1
            Console.WriteLine("After deletion, dictionary contains:");
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
        }

        // Stack CRUD Operations
        public static void StackOperations()
        {
            Console.WriteLine("\nStack Operations:");

            // Create
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Read (Peek)
            Console.WriteLine($"Top item of the stack: {stack.Peek()}"); // 3

            // Delete (Pop)
            int poppedItem = stack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}"); // 3

            // Check if an item exists in the stack
            bool containsItem = stack.Contains(2); // True
            Console.WriteLine($"Stack contains 2: {containsItem}");
        }

        // Queue CRUD Operations
        public static void QueueOperations()
        {
            Console.WriteLine("\nQueue Operations:");

            // Create
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Read (Peek)
            Console.WriteLine($"Front item of the queue: {queue.Peek()}"); // 1

            // Delete (Dequeue)
            int dequeuedItem = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {dequeuedItem}"); // 1

            // Check if an item exists in the queue
            bool containsQueueItem = queue.Contains(2); // True
            Console.WriteLine($"Queue contains 2: {containsQueueItem}");
        }

        // HashSet CRUD Operations
        public static void HashSetOperations()
        {
            Console.WriteLine("\nHashSet Operations:");

            // Create
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);

            // Read (Check if item exists)
            bool exists = set.Contains(2); // True
            Console.WriteLine($"Set contains 2: {exists}");

            // Delete
            set.Remove(1); // Removes item 1
            Console.WriteLine("After removal, set contains:");
            foreach (var item in set)
            {
                Console.WriteLine(item); // 2, 3
            }

            // Attempt to add a duplicate item (will not add)
            bool added = set.Add(2); // False, since 2 is already in the set
            Console.WriteLine($"Attempted to add duplicate 2: {added}");
        }

        // SortedSet CRUD Operations
        public static void SortedSetOperations()
        {
            Console.WriteLine("\nSortedSet Operations:");

            // Create
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(3);
            sortedSet.Add(1);
            sortedSet.Add(2);

            // Read (Check if item exists)
            bool containsSortedItem = sortedSet.Contains(2); // True
            Console.WriteLine($"SortedSet contains 2: {containsSortedItem}");

            // Delete
            sortedSet.Remove(1); // Removes item 1
            Console.WriteLine("After removal, sorted set contains:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item); // 2, 3
            }

            // Sorted order (Elements are sorted automatically)
            Console.WriteLine("Sorted elements in the set:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item); // 2, 3 (sorted)
            }
        }

        // Main function to call the CRUD methods for each collection
        //public static void Main(string[] args)
        //{
        //    Collections collections = new Collections();

        //    collections.DictionaryOperations();
        //    collections.StackOperations();
        //    collections.QueueOperations();
        //    collections.HashSetOperations();
        //    collections.SortedSetOperations();

        //    Console.ReadLine(); // To keep the console open
        //}
    }
}
