using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJECT
{
    public class SortedSet_
    {
        public void display()
        {
            // Create (Add)
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(3);
            sortedSet.Add(1);
            sortedSet.Add(2);

            // Read
            Console.WriteLine("Read from SortedSet:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);  // Outputs: 1, 2, 3 (sorted)
            }

            // Update (SortedSet does not allow direct updates, so remove and add)
            sortedSet.Remove(2);
            sortedSet.Add(4);

            Console.WriteLine("\nAfter Update:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);  // Outputs: 1, 3, 4
            }

            // Delete
            sortedSet.Remove(1);

            Console.WriteLine("\nAfter Delete:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);  // Outputs: 3, 4
            }
        }
    }
}
