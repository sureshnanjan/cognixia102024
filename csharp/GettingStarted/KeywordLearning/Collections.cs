using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Collection
    {
        public static void CollectionMethods()
        {
            // 1. List Collection
            Console.WriteLine("1. List Collection:");
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Diana");
            names.Remove("Bob");
            DisplayCollection(names);
            ReadOnlyCollection<string> readOnlyNames = names.AsReadOnly();
            Console.WriteLine("Read-only List:");
            DisplayCollection(readOnlyNames);

            // 2. Dictionary Collection
            Console.WriteLine("\n2. Dictionary Collection:");
            Dictionary<int, string> idNameMap = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };
            idNameMap[4] = "Diana";
            idNameMap.Remove(2);
            foreach (var kvp in idNameMap)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            ReadOnlyDictionary<int, string> readOnlyIdNameMap = new ReadOnlyDictionary<int, string>(idNameMap);
            Console.WriteLine("Read-only Dictionary:");
            foreach (var kvp in readOnlyIdNameMap)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // 3. HashSet Collection
            Console.WriteLine("\n3. HashSet Collection:");
            HashSet<string> uniqueNames = new HashSet<string> { "Alice", "Bob", "Charlie" };
            uniqueNames.Add("Alice");
            uniqueNames.Add("Diana");
            uniqueNames.Remove("Charlie");
            DisplayCollection(uniqueNames);
            var readOnlyUniqueNames = new ReadOnlyCollection<string>(new List<string>(uniqueNames));
            Console.WriteLine("Read-only HashSet:");
            DisplayCollection(readOnlyUniqueNames);

            // 4. Queue Collection
            Console.WriteLine("\n4. Queue Collection:");
            Queue<string> taskQueue = new Queue<string>();
            taskQueue.Enqueue("Task1");
            taskQueue.Enqueue("Task2");
            taskQueue.Enqueue("Task3");
            taskQueue.Dequeue();
            DisplayCollection(taskQueue);
            var readOnlyQueue = new ReadOnlyCollection<string>(new List<string>(taskQueue));
            Console.WriteLine("Read-only Queue:");
            DisplayCollection(readOnlyQueue);

            // 5. LinkedList Collection
            Console.WriteLine("\n5. LinkedList Collection:");
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Node1");
            linkedList.AddLast("Node2");
            linkedList.AddFirst("Node0");
            linkedList.Remove("Node1");
            DisplayCollection(linkedList);
            var readOnlyLinkedList = new ReadOnlyCollection<string>(new List<string>(linkedList));
            Console.WriteLine("Read-only LinkedList:");
            DisplayCollection(readOnlyLinkedList);

            // 6. PriorityQueue Collection (using .NET 6 or later)
            Console.WriteLine("\n6. PriorityQueue Collection:");
            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();
            priorityQueue.Enqueue("LowPriorityTask", 3);    // Lower number = Higher priority
            priorityQueue.Enqueue("HighPriorityTask", 1);
            priorityQueue.Enqueue("MediumPriorityTask", 2);
            while (priorityQueue.Count > 0)
            {
                string task = priorityQueue.Dequeue();
                Console.WriteLine(task);
            }
        }
        static void DisplayCollection(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
