using System;
using System.Collections.Generic;

namespace Mainfile
{
    public class SortedSetExample
    {
        private SortedSet<int> sortedSet = new SortedSet<int>();

        public void Execute()
        {
            // Create
            sortedSet.Add(2);
            sortedSet.Add(1);
            Console.WriteLine("Items added to sorted set.");

            // Read
            Console.WriteLine("Items in the sorted set:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }

            // Update (remove and add)
            if (sortedSet.Remove(1))
                sortedSet.Add(10);

            Console.WriteLine("Updated an item in the sorted set.");

            // Delete
            sortedSet.Remove(2);
            Console.WriteLine("Removed an item from the sorted set.");
        }
    }
}