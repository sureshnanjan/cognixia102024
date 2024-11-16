using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class DSDictionary
    {
        // Private dictionary to store key-value pairs
        private Dictionary<int, string> itemDictionary;

        // Constructor to initialize the dictionary
        public DSDictionary()
        {
            itemDictionary = new Dictionary<int, string>();
        }

        // Method to add a key-value pair to the dictionary
        public void Add(int key, string value)
        {
            if (!itemDictionary.ContainsKey(key))
            {
                itemDictionary.Add(key, value);
                Console.WriteLine($"Key {key} with value '{value}' added to the dictionary.");
            }
            else
            {
                Console.WriteLine($"Key {key} already exists in the dictionary.");
            }
        }

        // Method to remove a key-value pair by key
        public void Remove(int key)
        {
            if (itemDictionary.ContainsKey(key))
            {
                itemDictionary.Remove(key);
                Console.WriteLine($"Key {key} removed from the dictionary.");
            }
            else
            {
                Console.WriteLine($"Key {key} not found in the dictionary.");
            }
        }

        // Method to display all key-value pairs in the dictionary
        public void Display()
        {
            if (itemDictionary.Count == 0)
            {
                Console.WriteLine("The dictionary is empty.");
            }
            else
            {
                Console.WriteLine("Key-Value pairs in the dictionary:");
                foreach (var item in itemDictionary)
                {
                    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                }
            }
        }

        // Method to check if the dictionary contains a specific key
        public void ContainsKey(int key)
        {
            if (itemDictionary.ContainsKey(key))
            {
                Console.WriteLine($"Key {key} exists in the dictionary.");
            }
            else
            {
                Console.WriteLine($"Key {key} does not exist in the dictionary.");
            }
        }

        // Method to get the value by key
        public void GetValue(int key)
        {
            if (itemDictionary.TryGetValue(key, out string value))
            {
                Console.WriteLine($"The value for key {key} is '{value}'.");
            }
            else
            {
                Console.WriteLine($"Key {key} not found in the dictionary.");
            }
        }

        // Method to run sample operations for the dictionary
        public void Output(string[] args)
        {
            DSDictionary myDict = new DSDictionary();

            // Add key-value pairs
            myDict.Add(1, "Apple");
            myDict.Add(2, "Banana");
            myDict.Add(3, "Cherry");

            // Display the dictionary
            myDict.Display();

            // Check if a specific key exists
            myDict.ContainsKey(2);
            myDict.ContainsKey(5);

            // Get the value for a specific key
            myDict.GetValue(1);
            myDict.GetValue(4);

            // Remove a key-value pair
            myDict.Remove(2);
            myDict.Remove(5);

            // Display the dictionary after removal
            myDict.Display();
        }
    }
}

