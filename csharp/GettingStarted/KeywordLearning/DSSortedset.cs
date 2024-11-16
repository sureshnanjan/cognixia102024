using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class DSSortedSet
    {
        // Private sorted set to store unique items in sorted order
        private SortedSet<int> itemSortedSet;

        // Constructor to initialize the sorted set
        public DSSortedSet()
        {
            itemSortedSet = new SortedSet<int>();
        }

        // Method to add an item to the sorted set
        public void Add(int item)
        {
            if (itemSortedSet.Add(item)) // Add returns false if the item already exists
            {
                Console.WriteLine($"Item {item} added to the sorted set.");
            }
            else
            {
                Console.WriteLine($"Item {item} already exists in the sorted set.");
            }
        }

        // Method to remove an item from the sorted set
        public void Remove(int item)
        {
            if (itemSortedSet.Remove(item))
            {
                Console.WriteLine($"Item {item} removed from the sorted set.");
            }
            else
            {
                Console.WriteLine($"Item {item} not found in the sorted set.");
            }
        }

        // Method to check if the sorted set contains a specific item
        public void Contains(int item)
        {
            if (itemSortedSet.Contains(item))
            {
                Console.WriteLine($"Item {item} is present in the sorted set.");
            }
            else
            {
                Console.WriteLine($"Item {item} is not present in the sorted set.");
            }
        }

        // Method to display all items in the sorted set
        public void Display()
        {
            if (itemSortedSet.Count == 0)
            {
                Console.WriteLine("The sorted set is empty.");
            }
            else
            {
                Console.WriteLine("Items in the sorted set (sorted in ascending order):");
                foreach (var item in itemSortedSet)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Method to check if the sorted set is empty
        public void IsEmpty()
        {
            if (itemSortedSet.Count == 0)
            {
                Console.WriteLine("The sorted set is empty.");
            }
            else
            {
                Console.WriteLine("The sorted set is not empty.");
            }
        }

        // Method to clear all items in the sorted set
        public void Clear()
        {
            itemSortedSet.Clear();
            Console.WriteLine("All items have been removed from the sorted set.");
        }

        // Method to run sample operations for the sorted set
        public void Output(string[] args)
        {
            DSSortedSet mySortedSet = new DSSortedSet();

            // Add items to the sorted set
            mySortedSet.Add(10);
            mySortedSet.Add(20);
            mySortedSet.Add(30);
            mySortedSet.Add(20); // Duplicate, will not be added

            // Display the sorted set
            mySortedSet.Display();

            // Check if a specific item exists
            mySortedSet.Contains(20);
            mySortedSet.Contains(40);

            // Remove an item from the sorted set
            mySortedSet.Remove(20); // Removes item 20
            mySortedSet.Remove(40); // Item 40 does not exist

            // Display the sorted set after removal
            mySortedSet.Display();

            // Check if the sorted set is empty
            mySortedSet.IsEmpty();

            // Clear all items from the sorted set
            mySortedSet.Clear();

            // Display the sorted set after clearing
            mySortedSet.Display();
        }
    }
}

