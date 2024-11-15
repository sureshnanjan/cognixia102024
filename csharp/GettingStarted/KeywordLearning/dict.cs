using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    /// <summary>
    /// Demonstrates CRUD operations on a Dictionary.
    /// </summary>
    public class DictionaryExample
    {
        private Dictionary<int, string> students = new Dictionary<int, string>();

        /// <summary>
        /// Executes the CRUD operations on the dictionary.
        /// </summary>
        public void Execute()
        {
            // Create
            students.Add(1, "Alice");
            students.Add(2, "Bob");
            Console.WriteLine("Students added.");

            // Read
            Console.WriteLine("Students in the dictionary:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }

            // Update
            students[1] = "Alicia"; // Update name for ID 1
            Console.WriteLine("Updated student ID 1 to Alicia.");

            // Delete
            students.Remove(2); // Remove student with ID 2
            Console.WriteLine("Removed student ID 2.");
        }
    }
}