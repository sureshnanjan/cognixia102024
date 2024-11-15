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
using System.Collections.Specialized;

namespace KeywordLearning
{
    // List Example
    public class ListExample
    {
        public void Demo()
        {
            Console.WriteLine("--------Example for List Collection--------");
            List<string> countries = new List<string> { "USA", "Canada", "Mexico" };

            // Add
            countries.Add("Brazil");
            countries.AddRange(new List<string> { "Argentina", "Chile" });

            // Read
            Console.WriteLine("Countries List:");
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            // Update
            int index = countries.IndexOf("Canada");
            if (index != -1)
            {
                countries[index] = "Canada (Updated)";
            }

            // Delete
            countries.Remove("Mexico");

            Console.WriteLine("After Update and Delete:");
            countries.ForEach(Console.WriteLine);
        }
    }

    // Dictionary Example
    public class DictionaryExample
    {
        public void Demo()
        {
            Console.WriteLine("--------Example for Dictionary Collection--------");
            Dictionary<string, int> population = new Dictionary<string, int>
            {
                { "New York", 8419600 },
                { "Los Angeles", 3980400 },
                { "Chicago", 2716000 }
            };

            // Add
            population["Houston"] = 2328000;

            // Read
            Console.WriteLine("Population Dictionary:");
            foreach (var city in population)
                Console.WriteLine($"{city.Key}: {city.Value}");

            // Update
            if (population.ContainsKey("Los Angeles"))
                population["Los Angeles"] = 4000000;

            // Delete
            population.Remove("Chicago");

            Console.WriteLine("After Update and Delete:");
            foreach (var city in population)
                Console.WriteLine($"{city.Key}: {city.Value}");
        }
    }

    // Queue Example
    public class QueueExample
    {
        public void Demo()
        {
            Console.WriteLine("--------Example for Queue Collection--------");
            Queue<string> tasks = new Queue<string>();

            // Add (Enqueue)
            tasks.Enqueue("Task 1");
            tasks.Enqueue("Task 2");
            tasks.Enqueue("Task 3");

            // Read and Remove (Dequeue)
            Console.WriteLine("Processing Tasks:");
            while (tasks.Count > 0)
            {
                Console.WriteLine($"Processing: {tasks.Dequeue()}");
            }

            // Queue is now empty
            Console.WriteLine($"Queue count after processing: {tasks.Count}");
        }
    }

    // Stack Example
    public class StackExample
    {
        public void Demo()
        {
            Console.WriteLine("--------Example for Stack Collection--------");
            Stack<string> books = new Stack<string>();

            // Add
            books.Push("Book A");
            books.Push("Book B");
            books.Push("Book C");

            // Read and Remove
            Console.WriteLine("Removing Books from Stack:");
            while (books.Count > 0)
            {
                Console.WriteLine($"Removing: {books.Pop()}");
            }

            Console.WriteLine($"Stack count after clearing: {books.Count}");
        }
    }

    // HashSet Example
    public class HashSetExample
    {
        public void Demo()
        {
            Console.WriteLine("--------Example for HashSet Collection--------");
            HashSet<string> fruits = new HashSet<string> { "Apple", "Banana", "Cherry" };

            // Add
            fruits.Add("Mango");
            bool added = fruits.Add("Apple"); // Duplicate, will return false

            // Read
            Console.WriteLine("Fruits in HashSet:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine($"Attempt to add duplicate 'Apple': {added}");

            // Delete
            fruits.Remove("Banana");
            Console.WriteLine("After Removing Banana:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }

    // LinkedList Example 
    public class LinkedListExample
    {
        public void Demo()
        {
            Console.WriteLine("--------Example for LinkedList Collection--------");
            LinkedList<string> pets = new LinkedList<string>();

            // Add
            pets.AddLast("Cat");
            pets.AddLast("Dog");
            pets.AddFirst("Parrot");

            // Read
            Console.WriteLine("Pets LinkedList:");
            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }

            // Update (Remove and Add)
            pets.Remove("Cat");
            pets.AddLast("Hamster");

            Console.WriteLine("After Update:");
            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }

            // Delete
            pets.Clear();
            Console.WriteLine($"LinkedList count after clearing: {pets.Count}");
        }
    }

    // PriorityQueue Example
    public class PriorityQueueExample
    {
        public void Demo()
        {
            Console.WriteLine("--------Example for PriorityQueue Collection--------");
            PriorityQueue<string, int> events = new PriorityQueue<string, int>();

            // Add
            events.Enqueue("Test", 2);
            events.Enqueue("Develop", 1);
            events.Enqueue("Bug", 3);

            // Read and Remove
            Console.WriteLine("Processing Events by Priority:");
            while (events.Count > 0)
            {
                Console.WriteLine($"Processing: {events.Dequeue()}");
            }

            Console.WriteLine($"PriorityQueue count after clearing: {events.Count}");
        }
    }
}
