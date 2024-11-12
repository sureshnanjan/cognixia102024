/*
 
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
 
*/
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
