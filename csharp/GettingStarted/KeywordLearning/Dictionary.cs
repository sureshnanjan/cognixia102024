using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Dictionary
    {
        public static void Main()
        {
            // Create
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");

            // Read
            Console.WriteLine("Value for key 1: " + dictionary[1]); // Output: One

            // Update
            if (dictionary.ContainsKey(2))
            {
                dictionary[2] = "Updated Two"; // Update the value of key 2
            }

            // Delete
            dictionary.Remove(1); // Remove key 1

            // Display all items
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
