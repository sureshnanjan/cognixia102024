using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    public class Generic
    {
        private Queue<string> queue;
        private List<int> list;
        private HashSet<string> hashSet;
        private PriorityQueue<string, int> priorityQueue;
        private Dictionary<int, string> dictionary;
        private LinkedList<string> linkedList;
        private Stack<string> stack;
        private SortedDictionary<int, string> sortedDictionary;
        public Generic()
        {
            queue = new Queue<string>();
            list = new List<int>();
            hashSet = new HashSet<string>();
            priorityQueue = new PriorityQueue<string, int>();
            dictionary = new Dictionary<int, string>();
            linkedList = new LinkedList<string>();
            stack = new Stack<string>();
            sortedDictionary = new SortedDictionary<int, string>();

        }
        public void AddToCollections()
        {
            // Add to Queue
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            // Add to List
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Add to HashSet
            hashSet.Add("Red");
            hashSet.Add("Green");
            hashSet.Add("Blue");

            // Add to PriorityQueue
            priorityQueue.Enqueue("LowPriorityTask", 3);
            priorityQueue.Enqueue("HighPriorityTask", 1);
            priorityQueue.Enqueue("MediumPriorityTask", 2);

            // Add to Dictionary
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");

            // Add to LinkedList
            linkedList.AddLast("First");
            linkedList.AddLast("Second");
            linkedList.AddLast("Third");

            // Add to Stack
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            // Add to SortedDictionary
            sortedDictionary.Add(3, "Three");
            sortedDictionary.Add(1, "One");
            sortedDictionary.Add(2, "Two");

            Console.WriteLine("\nCollections initialized with sample data.");
        }

        // Display all collections
        public void DisplayCollections()
        {
            Console.WriteLine("\n--- Queue ---");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--- List ---");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--- HashSet ---");
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--- PriorityQueue ---");
            foreach (var item in priorityQueue.UnorderedItems)
            {
                Console.WriteLine($"{item.Element}: {item.Priority}");
            }

            Console.WriteLine("\n--- Dictionary ---");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("\n--- LinkedList ---");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--- Stack ---");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--- SortedDictionary ---");
            foreach (var item in sortedDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        // Modify elements in the collections
        public void ModifyCollections()
        {
            // Modify List
            if (list.Contains(20))
            {
                list[list.IndexOf(20)] = 25; // Update 20 to 25
            }

            // Modify HashSet
            if (hashSet.Contains("Green"))
            {
                hashSet.Remove("Green");
                hashSet.Add("Yellow"); // Remove Green and add Yellow
            }

            // Modify PriorityQueue (Re-enqueue with updated priority)
            priorityQueue.Enqueue("LowPriorityTask", 4); // Change the priority of an existing task

            // Modify Dictionary
            if (dictionary.ContainsKey(2))
            {
                dictionary[2] = "Updated Two"; // Update the value for key 2
            }

            // Modify LinkedList
            LinkedListNode<string> node = linkedList.Find("Second");
            if (node != null) node.Value = "Updated Second";

            // Modify Stack
            string poppedItem = stack.Pop();
            stack.Push("Fourth");

            // Modify SortedDictionary
            if (sortedDictionary.ContainsKey(1))
            {
                sortedDictionary[1] = "Updated One"; // Update the value for key 1
            }

            Console.WriteLine("\nCollections have been modified.");
        }

        // Delete elements from collections
        public void DeleteFromCollections()
        {
            // Delete from Queue
            queue.Dequeue(); // Remove the first element

            // Delete from List
            list.Remove(30); // Remove the element 30

            // Delete from HashSet
            hashSet.Remove("Red"); // Remove "Red" from HashSet

            // Delete from PriorityQueue
            priorityQueue.Dequeue(); // Remove the highest priority element

            // Delete from Dictionary
            dictionary.Remove(3); // Remove the key-value pair with key 3

            // Delete from LinkedList
            linkedList.Remove("First");

            // Delete from Stack
            stack.Pop(); // Remove the top element

            // Delete from SortedDictionary
            sortedDictionary.Remove(2); // Remove the key-value pair with key 2

            Console.WriteLine("\nElements deleted from collections.");
        }
    }
}
