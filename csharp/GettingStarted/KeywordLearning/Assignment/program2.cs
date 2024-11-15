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

namespace KeywordLearning.Assignment
{
   
    public class CollectionOperations
    {
        // CRUD Operations for Dictionary
        public void DictionaryCRUD()
        {
            // Create
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");

            // Read
            if (dictionary.ContainsKey(1))
            {
                Console.WriteLine($"Key 1: {dictionary[1]}");  // Output: Apple
            }

            // Update
            if (dictionary.ContainsKey(2))
            {
                dictionary[2] = "Blueberry";
                Console.WriteLine($"Updated Key 2: {dictionary[2]}");  // Output: Blueberry
            }

            // Delete
            if (dictionary.ContainsKey(1))
            {
                dictionary.Remove(1);
                Console.WriteLine("Key 1 removed");
            }
        }

        // CRUD Operations for Stack
        public void StackCRUD()
        {
            // Create
            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");

            // Read (Peek)
            if (stack.Count > 0)
            {
                Console.WriteLine($"Top element: {stack.Peek()}");  // Output: Second
            }

            // Update (Stack doesn't support direct update, so Pop and Push)
            if (stack.Count > 0)
            {
                stack.Pop(); // Pop 'Second'
                stack.Push("Updated Second");
                Console.WriteLine($"Updated top element: {stack.Peek()}");  // Output: Updated Second
            }

            // Delete (Pop)
            if (stack.Count > 0)
            {
                stack.Pop();
                Console.WriteLine("One element removed from stack");
            }
        }

        // CRUD Operations for Queue
        public void QueueCRUD()
        {
            // Create
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");

            // Read (Peek)
            if (queue.Count > 0)
            {
                Console.WriteLine($"Front element: {queue.Peek()}");  // Output: First
            }

            // Update (Queue doesn't support direct update, so Dequeue and Enqueue)
            if (queue.Count > 0)
            {
                queue.Dequeue(); // Dequeue 'First'
                queue.Enqueue("Updated First");
                Console.WriteLine($"Updated front element: {queue.Peek()}");  // Output: Updated First
            }

            // Delete (Dequeue)
            if (queue.Count > 0)
            {
                queue.Dequeue();
                Console.WriteLine("One element removed from queue");
            }
        }

        // CRUD Operations for Set
        public void SetCRUD()
        {
            // Create
            HashSet<string> set = new HashSet<string>();
            set.Add("Apple");
            set.Add("Banana");

            // Read
            if (set.Contains("Apple"))
            {
                Console.WriteLine("Set contains Apple");
            }

            // Update (Set does not support direct update, we can add or remove elements)
            set.Remove("Banana");
            set.Add("Orange");
            Console.WriteLine("Set updated with Orange");

            // Delete
            set.Remove("Apple");
            Console.WriteLine("Apple removed from set");
        }

        // CRUD Operations for SortedSet
        public void SortedSetCRUD()
        {
            // Create
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(10);
            sortedSet.Add(5);
            sortedSet.Add(20);

            // Read (Sorted order)
            Console.WriteLine("SortedSet elements: ");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);  // Output: 5, 10, 20
            }

            // Update (SortedSet doesn't support direct update, so remove and add)
            sortedSet.Remove(5);
            sortedSet.Add(15);
            Console.WriteLine("SortedSet updated");

            // Delete
            sortedSet.Remove(20);
            Console.WriteLine("20 removed from SortedSet");
        }
    }

}
