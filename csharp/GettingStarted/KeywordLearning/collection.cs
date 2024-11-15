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
namespace KeywordLearning;
 
using System.Collections.Generic;
using System.Collections.Specialized;

public class collection
{

    public static void demo()
    {

        Console.WriteLine("--------Example for the Collection--------");
        Console.WriteLine("--------example for the list-----------");
        ///list
        ///for  List CRUD
        ///Creating a List
        List<int> mylist = new List<int> { 1, 2, 3, };
        List<String> mystring = new List<String> { "Apple", "Banana", "Cherry" };
        /// Adding Elements
        mystring.Add("orange");
        mystring.Add("stawberry");
        mylist.Add(1);
        mylist.Add(2);
        mylist.Add(3);
        //Addrange method
        mystring.AddRange(new List<string>{ "Elderberry", "Fig", "Grape" });
       
        ///Accessing Elements by its index
        Console.WriteLine(mystring[0]);
        Console.WriteLine(mystring[1]);
        Console.WriteLine(mylist[0]);
        Console.WriteLine(mystring[2]);

        ///Iterating through a List
        for (int i = 0; i < mylist.Count; i++)
        {
            Console.WriteLine(mylist[i]);
        }
        foreach(var mystrings in mystring)
        {
            Console.WriteLine(mystrings);
        }

        for (int i = 0; i < mystring.Count; i++)
        {
            Console.WriteLine($"Index {i}: {mystring[i]}");
        }
        ///List Methods
        mylist.Sort();
        mystring.Reverse();
        
        mylist.Insert( 2, 3);
        string fruit = mystring.Find(f => f.StartsWith("C"));
        Console.WriteLine(fruit);
        ///to clear
        mylist.Clear();
        mystring.RemoveAll(f => f.StartsWith("B"));
        Console.WriteLine("--------example for the Dictionary-----------");
        ///dictionary
        ///crud for dictionary
        /////create
        Dictionary<string, int> fruitPrices = new Dictionary<string, int>();
        Dictionary<string, int> fruitStock = new Dictionary<string, int>
        {
            { "Apple", 100 },
            { "Banana", 150 },
            { "Cherry", 200 }
        };
        //add or  update
        fruitPrices.Add("Apple", 2);
        fruitPrices.Add("Banana", 1);
        fruitPrices.Add("Cherry", 3);
        fruitPrices["Dates"] = 4;
        //Accessing Values
        Console.WriteLine(fruitStock["Apple"]);
        if (fruitPrices.TryGetValue("Banana", out int price))
        {
            Console.WriteLine($"Price of Banana: {price}");
        }
        else
        {
            Console.WriteLine("Banana not found.");
        }
        if (fruitStock.ContainsValue(100))
        {
            Console.WriteLine("Apple is present ");
        }
        else
        {
            Console.WriteLine("Apple is not there");
        }
        if (fruitStock.ContainsKey("Pineapple"))
        {
            Console.WriteLine("Apple is present ");
        }
        else
        {
            Console.WriteLine("Apple is not there");
        }
        //iterration
        foreach (var iteam in fruitPrices.Keys)
        {
            Console.WriteLine(iteam);
        }

        ///reamove
        fruitPrices.Remove("Cherry");
        Console.WriteLine(fruitPrices.Count);
        Console.WriteLine("--------Example for the Queue-----------");

        // Create a Queue
        Queue<string> fruitQueue = new Queue<string>();

        // CRUD Operations

        // Create: Add elements to the queue
        fruitQueue.Enqueue("Apple");
        fruitQueue.Enqueue("Banana");
        fruitQueue.Enqueue("Cherry");

        // Read: Access the first element in the queue without removing it
        Console.WriteLine("First item in the queue: " + fruitQueue.Peek());

        // Read: Dequeue the first item (removes the item)
        string dequeuedFruit = fruitQueue.Dequeue();
        Console.WriteLine($"Dequeued: {dequeuedFruit}");

        // After dequeue
        Console.WriteLine("After dequeue, first item: " + fruitQueue.Peek());

        // Update: Enqueue a new item (queue does not have an "update" method, but you can dequeue and then enqueue a new value)
        fruitQueue.Enqueue("Dates");

        // Checking the elements in the queue
        Console.WriteLine("Elements in the queue:");
        foreach (var fruits in fruitQueue)
        {
            Console.WriteLine(fruits);
        }

        // Delete: Clear the queue
        fruitQueue.Clear();
        Console.WriteLine($"Queue count after clearing: {fruitQueue.Count}");

       Console.WriteLine("Queue is not empty.");
       

            Console.WriteLine("--------Example for the Stack-----------");

            // Create a Stack
            Stack<string> fruitStack = new Stack<string>();

            // CRUD Operations

            // Create: Push elements onto the stack
            fruitStack.Push("Apple");
            fruitStack.Push("Banana");
            fruitStack.Push("Cherry");

            // Read: Peek the top element in the stack without removing it
            Console.WriteLine("Top item in the stack: " + fruitStack.Peek());

            // Read: Pop the top element (removes the item)
            string poppedFruit = fruitStack.Pop();
            Console.WriteLine($"Popped: {poppedFruit}");

            // After pop
            Console.WriteLine("After pop, top item: " + fruitStack.Peek());

            // Update: Stack does not have a direct update operation, but we can pop and then push a new value
            fruitStack.Push("Dates");

            // Checking the elements in the stack (will display from top to bottom)
            Console.WriteLine("Elements in the stack (top to bottom):");
            foreach (var fruit1 in fruitStack)
            {
                Console.WriteLine(fruit1);
            }

            // Delete: Clear the stack
            fruitStack.Clear();
            Console.WriteLine($"Stack count after clearing: {fruitStack.Count}");

        Console.WriteLine("--------Example for the HashSet-----------");

        // Create a HashSet
        HashSet<string> fruitSet = new HashSet<string>();

        // CRUD Operations

        // Create: Add elements to the HashSet
        fruitSet.Add("Apple");
        fruitSet.Add("Banana");
        fruitSet.Add("Cherry");

        // Read: Check if a particular element exists in the HashSet
        Console.WriteLine("Contains 'Apple': " + fruitSet.Contains("Apple"));
        Console.WriteLine("Contains 'Orange': " + fruitSet.Contains("Orange"));

        // Attempt to add duplicate item (HashSet does not allow duplicates)
        bool added = fruitSet.Add("Banana"); // This will return false because "Banana" is already in the set
        Console.WriteLine("Trying to add 'Banana' again: " + added);  // Output will be 'false'

        // Update: HashSets do not support direct updates. You would remove an item and then add it again if necessary.
        // For example, if we wanted to replace "Apple" with "Dates", we'd first remove "Apple" and then add "Dates":
        fruitSet.Remove("Apple");
        fruitSet.Add("Dates");

        // Read: Display all items in the HashSet
        Console.WriteLine("Items in the HashSet:");
        foreach (var fruit2 in fruitSet)
        {
            Console.WriteLine(fruit2);
        }

        // Delete: Clear the HashSet (remove all elements)
        fruitSet.Clear();
        Console.WriteLine($"HashSet count after clearing: {fruitSet.Count}");
        ///////LINKED LIST
        Console.WriteLine("--------Example for the LinkedList-----------");

        // Create a LinkedList of strings
        LinkedList<string> fruitList = new LinkedList<string>();

        // CRUD Operations

        // Create: Add elements to the LinkedList
        fruitList.AddLast("Apple");
        fruitList.AddLast("Banana");
        fruitList.AddLast("Cherry");

        // Read: Accessing the first and last elements in the LinkedList
        Console.WriteLine("First item in the LinkedList: " + fruitList.First.Value);
        Console.WriteLine("Last item in the LinkedList: " + fruitList.Last.Value);

        // Read: Searching for a specific element in the LinkedList
        var node = fruitList.Find("Banana");
        if (node != null)
        {
            Console.WriteLine("Found 'Banana': " + node.Value);
        }
        else
        {
            Console.WriteLine("'Banana' not found.");
        }

        // Update: LinkedLists don't have a direct update method, but you can remove and add items
        // For example, replace "Banana" with "Dates" by removing and then adding it
        fruitList.Remove("Banana");
        fruitList.AddLast("Dates");

        // Checking all elements in the LinkedList
        Console.WriteLine("Items in the LinkedList:");
        foreach (var fruit6 in fruitList)
        {
            Console.WriteLine(fruit6);
        }

        // Delete: Remove the first element (using RemoveFirst)
        fruitList.RemoveFirst();
        Console.WriteLine("After RemoveFirst, items in the LinkedList:");
        foreach (var fruit5 in fruitList)
        {
            Console.WriteLine(fruit5);
        }

        // Delete: Remove the last element (using RemoveLast)
        fruitList.RemoveLast();
        Console.WriteLine("After RemoveLast, items in the LinkedList:");
        foreach (var fruit4 in fruitList)
        {
            Console.WriteLine(fruit4);
        }

        // Delete: Clear the LinkedList (removes all elements)
        fruitList.Clear();
        Console.WriteLine($"LinkedList count after clearing: {fruitList.Count}");
        Console.WriteLine("--------Example for the PriorityQueue-----------");

        // Create a PriorityQueue (min-heap by default)
        // The priority queue stores tuples (value, priority), where priority determines the order
        PriorityQueue<string, int> fruitQueue1 = new PriorityQueue<string, int>();

        // CRUD Operations

        // Create: Add elements with priorities
        fruitQueue1.Enqueue("Apple", 2);    // Priority 2
        fruitQueue1.Enqueue("Banana", 1);   // Priority 1 (higher priority because lower number)
        fruitQueue1.Enqueue("Cherry", 3);   // Priority 3

        // Read: Peek the first element (highest priority)
        if (fruitQueue1.Count > 0)
        {
            var topFruit = fruitQueue1.Peek();
            Console.WriteLine($"Top item in the PriorityQueue: {topFruit}");
        }

        // Read: Dequeue the top element (highest priority)
        var dequeuedFruits = fruitQueue1.Dequeue();
        Console.WriteLine($"Dequeued: {dequeuedFruits}");

        // Read again: Check the new top item after dequeue
        if (fruitQueue1.Count > 0)
        {
            var nextTopFruit = fruitQueue1.Peek();
            Console.WriteLine($"Next top item in the PriorityQueue: {nextTopFruit}");
        }

        // Update: PriorityQueue doesn't allow direct updates, but you can enqueue with a new priority after removal
        // For example, change "Apple" priority to 0 (highest priority)
        // Remove "Apple", then re-enqueue with the new priority
        fruitQueue1.Enqueue("Apple", 0);

        // Check all items in the PriorityQueue (Note: PriorityQueue does not allow direct iteration)
        Console.WriteLine("Items in the PriorityQueue after updating:");
        while (fruitQueue.Count > 0)
        {
            var fruit0 = fruitQueue.Dequeue();
            Console.WriteLine(fruit0);
        }

        // Delete: The PriorityQueue automatically removes elements when you call Dequeue, or you can clear it manually
        fruitQueue1.Enqueue("Dates", 4);
        fruitQueue1.Enqueue("Elderberry", 5);
        Console.WriteLine($"PriorityQueue count before clearing: {fruitQueue.Count}");
        fruitQueue.Clear();
        Console.WriteLine($"PriorityQueue count after clearing: {fruitQueue.Count}");

        
    }
}

    








