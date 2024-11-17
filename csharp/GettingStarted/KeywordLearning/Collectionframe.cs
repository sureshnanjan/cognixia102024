using System;
using System.Collections.Generic;

namespace KeywordLearning
{
    public class Collectionframe
    {
        public static void Collectionmethods()
        {
            // 1. List Collection: A simple list of integers
            Console.WriteLine("1. List Collection:");
            List<int> numbers = new List<int> { 10, 20, 30, 40 };
            numbers.Add(50); // Adding an element
            numbers.Remove(20); // Removing an element
            DisplayCollection(numbers);

            // 2. Dictionary Collection: A dictionary with student names and their ages
            Console.WriteLine("\n2. Dictionary Collection:");
            Dictionary<string, int> students = new Dictionary<string, int>
            {
                { "Alice", 21 },
                { "Bob", 22 },
                { "Charlie", 23 }
            };
            students["Diana"] = 24; // Adding a new key-value pair
            students.Remove("Bob"); // Removing a key-value pair
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Key}, Age: {student.Value}");
            }

            // 3. Queue Collection: A queue for tasks
            Console.WriteLine("\n3. Queue Collection:");
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Task 1");
            tasks.Enqueue("Task 2");
            tasks.Enqueue("Task 3");
            Console.WriteLine("Processing: " + tasks.Dequeue()); // Dequeues the first task
            DisplayCollection(tasks);
        }

        static void DisplayCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

