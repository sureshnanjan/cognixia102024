using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Set
    {
        public static void Main()
        {
            // Create
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);

            // Read
            Console.WriteLine("Contains 1: " + set.Contains(1)); // Output: True

            // Update (Remove and add a new element)
            set.Remove(2); // Remove 2
            set.Add(3); // Add 3

            // Delete
            set.Remove(1); // Remove 1

            // Display all items
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
