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
    public class Curd
    {
        public void DictionaryEx()
        {
            // Create
            var dictionary = new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" }
            };

            // Read
            Console.WriteLine("Dictionary Content:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Update
            dictionary[2] = "Two Updated";
            Console.WriteLine("Updated Dictionary:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Delete
            dictionary.Remove(1);
            Console.WriteLine("Dictionary after removal:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }

        public void StackEx()
        {
            // Create
            var stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            // Read
            Console.WriteLine("Stack Content:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Update (Stack doesn't support direct update; you have to pop and re-push items)
            stack.Pop();
            stack.Push("Third Updated");
            Console.WriteLine("Updated Stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Delete
            stack.Pop();
            Console.WriteLine("Stack after pop:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public void QueueEx()
        {
            // Create
            var queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            // Read
            Console.WriteLine("Queue Content:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Update (Queue doesn't support direct update; you have to dequeue and re-enqueue items)
            queue.Dequeue();
            queue.Enqueue("Third Updated");
            Console.WriteLine("Updated Queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Delete
            queue.Dequeue();
            Console.WriteLine("Queue after dequeue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public void SetEx()
        {
            // Create
            var set = new HashSet<int> { 1, 2, 3 };

            // Read
            Console.WriteLine("HashSet Content:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // Update (HashSet doesn't support direct update; you must remove and re-add items)
            set.Remove(2);
            set.Add(2); // Add updated value
            Console.WriteLine("Updated HashSet:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // Delete
            set.Remove(1);
            Console.WriteLine("HashSet after removal:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

        public void SortedSetEx()
        {
            // Create
            var sortedSet = new SortedSet<int> { 3, 1, 2 };

            // Read
            Console.WriteLine("SortedSet Content:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }

            // Update (SortedSet doesn't support direct update; you must remove and re-add items)
            sortedSet.Remove(2);
            sortedSet.Add(2); // Add updated value
            Console.WriteLine("Updated SortedSet:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }

            // Delete
            sortedSet.Remove(1);
            Console.WriteLine("SortedSet after removal:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
