using System;
using System.Collections.Generic;

namespace Mainfile
{
    public class SetExample
    {
        private HashSet<string> set = new HashSet<string>();

        public void Execute()
        {
            // Create
            set.Add("Item 1");
            set.Add("Item 2");
            Console.WriteLine("Items added to set.");

            // Read
            Console.WriteLine("Items in the set:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // Update (remove and add)
            if (set.Remove("Item 1"))
                set.Add("Updated Item 1");

            Console.WriteLine("Updated an item in the set.");

            // Delete
            set.Remove("Item 2");
            Console.WriteLine("Removed an item from the set.");
        }
    }
}