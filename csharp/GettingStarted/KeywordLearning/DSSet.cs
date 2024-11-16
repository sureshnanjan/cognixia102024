using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class DSSet
    {
        // Private set to store unique items
        private HashSet<int> itemSet;

        // Constructor to initialize the set
        public DSSet()
        {
            itemSet = new HashSet<int>();
        }

        // Method to add an item to the set
        public void Add(int item)
        {
            if (itemSet.Add(item)) // Add returns false if the item already exists
            {
                Console.WriteLine($"Item {item} added to the set.");
            }
            else
            {
                Console.WriteLine($"Item {item} already exists in the set.");
            }
        }

        // Method to remove an item from the set
        public void Remove(int item)
        {
            if (itemSet.Remove(item))
            {
                Console.WriteLine($"Item {item} removed from the set.");
            }
            else
            {
                Console.WriteLine($"Item {item} not found in the set.");
            }
        }

        // Method to check if the set contains a specific item
        public void Contains(int item)
        {
            if (itemSet.Contains(item))
            {
                Console.WriteLine($"Item {item} is present in the set.");
            }
            else
            {
                Console.WriteLine($"Item {item} is not present in the set.");
            }
        }

        // Method to display all items in the set
        public void Display()
        {
            if (itemSet.Count == 0)
            {
                Console.WriteLine("The set is empty.");
            }
            else
            {
                Console.WriteLine("Items in the set:");
                foreach (var item in itemSet)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Method to check if the set is empty
        public void IsEmpty()
        {
            if (itemSet.Count == 0)
            {
                Console.WriteLine("The set is empty.");
            }
            else
            {
                Console.WriteLine("The set is not empty.");
            }
        }

        // Method to run sample operations for the set
        public void Output(string[] args)
        {
            DSSet mySet = new DSSet();

            // Add items to the set
            mySet.Add(10);
            mySet.Add(20);
            mySet.Add(30);
            mySet.Add(20); // Duplicate, will not be added

            // Display the set
            mySet.Display();

            // Check if a specific item exists
            mySet.Contains(20);
            mySet.Contains(40);

            // Remove an item from the set
            mySet.Remove(20); // Removes item 20
            mySet.Remove(40); // Item 40 does not exist

            // Display the set after removal
            mySet.Display();

            // Check if the set is empty
            mySet.IsEmpty();
        }
    }
}
