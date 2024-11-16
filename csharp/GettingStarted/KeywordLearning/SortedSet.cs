using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class SortedSet
    {
        public static void Main()
        {
            // Create
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(2);
            sortedSet.Add(1);

            // Read
            Console.WriteLine("Smallest element: " + sortedSet.Min); // Output: 1

            // Update (Remove and add a new element)
            sortedSet.Remove(1); // Remove 1
            sortedSet.Add(3); // Add 3

            // Delete
            sortedSet.Remove(2); // Remove 2

            // Display all items in sorted order
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}