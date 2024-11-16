using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class DSList
    {
        // Private list to store items
        private List<int> itemList;

        // Constructor to initialize the list
        public DSList()
        {
            itemList = new List<int>();
        }

        // Method to insert an item at the end of the list
        public void InsertItem(int item)
        {
            itemList.Add(item);
            Console.WriteLine($"Item {item} inserted.");
        }

        // Method to insert an item at a specific position
        public void InsertItem(int item, int position)
        {
            if (position >= 0 && position <= itemList.Count)
            {
                itemList.Insert(position, item);
                Console.WriteLine($"Item {item} inserted at position {position}.");
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
        }

        // Method to delete an item by value
        public void DeleteItem(int item)
        {
            if (itemList.Contains(item))
            {
                itemList.Remove(item);
                Console.WriteLine($"Item {item} deleted.");
            }
            else
            {
                Console.WriteLine("Item not found in the list.");
            }
        }

        // Method to display all items in the list
        public void DisplayList()
        {
            if (itemList.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                string result = string.Join(" ", itemList);
                Console.WriteLine(result);
            }
        }

        public void Output(string[] args)
        {
            DSList myList = new DSList();

            // Insert items using the InsertItem method
            myList.InsertItem(10);// Inserting 5 at the end
            myList.InsertItem(20);// Inserting 10 at the end
            myList.InsertItem(30);// Inserting 15 at the end

            // Insert an item at a specific position
            myList.InsertItem(15, 1); // Insert 7 at position 1

            // Display the list
            myList.DisplayList();

            // Delete an item from the list
            myList.DeleteItem(10); // Delete item 10 from the list

            // Display the list after deletion
            myList.DisplayList();
        }
    }
}
