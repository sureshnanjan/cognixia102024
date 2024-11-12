using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class DictionaryCRUD<K, V>
    {
        private Dictionary<K, V> dictionary;

        // Constructor to initialize the dictionary
        public DictionaryCRUD()
        {
            dictionary = new Dictionary<K, V>();
        }

        // Create: Add a key-value pair to the dictionary
        public void Add(K key, V value)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
                Console.WriteLine($"Added: Key = {key}, Value = {value}");
            }
            else
            {
                Console.WriteLine($"Key {key} already exists. Use Update to modify the value.");
            }
        }

        // Read: Get the value associated with a key
        public V Get(K key)
        {
            if (dictionary.ContainsKey(key))
            {
                return dictionary[key];
            }
            else
            {
                throw new KeyNotFoundException($"Key {key} not found.");
            }
        }

        // Update: Modify the value for an existing key
        public void Update(K key, V newValue)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = newValue;
                Console.WriteLine($"Updated: Key = {key}, New Value = {newValue}");
            }
            else
            {
                Console.WriteLine($"Key {key} not found. Use Add to insert a new key-value pair.");
            }
        }

        // Delete: Remove a key-value pair from the dictionary
        public void Delete(K key)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary.Remove(key);
                Console.WriteLine($"Deleted: Key = {key}");
            }
            else
            {
                Console.WriteLine($"Key {key} not found.");
            }
        }

        // Display all key-value pairs in the dictionary
        public void DisplayDictionary()
        {
            if (dictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is empty.");
            }
            else
            {
                Console.WriteLine("Dictionary contents:");
                foreach (var kvp in dictionary)
                {
                    Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
                }
            }
        }

        // Check if a key exists in the dictionary
        public bool ContainsKey(K key)
        {
            return dictionary.ContainsKey(key);
        }

        // Check if the dictionary is empty
        public bool IsEmpty()
        {
            return dictionary.Count == 0;
        }
    }


}
