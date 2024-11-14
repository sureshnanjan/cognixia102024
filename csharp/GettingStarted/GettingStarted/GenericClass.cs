using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    
    public class GenericClass
    {
     
        public void run()
        { 
           //1.Dictionary
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "One");
        dict.Add(2, "Two");
        dict.Add(3, "Three");
        Console.WriteLine("Dictionary after creation: ");
        foreach (var item in dict) Console.WriteLine($"{item.Key}: {item.Value}");

       
        Console.WriteLine("Value for key 2: " + dict[2]);

        dict[2] = "Updated Two"; 
        Console.WriteLine("Dictionary after update: ");
        foreach (var item in dict) Console.WriteLine($"{item.Key}: {item.Value}");

        dict.Remove(3);  
        Console.WriteLine("Dictionary after deletion: ");
        foreach (var item in dict) Console.WriteLine($"{item.Key}: {item.Value}");

        Console.WriteLine();
        //2.KeyNotFoundException
            try
            {
                Console.WriteLine("Value for key 5: " + dict[5]); 
            }
            catch (KeyNotFoundException ex)
            {
                
                Console.WriteLine("Error: " + ex.Message); 
            }

         //3.List
            List<string> list = new List<string> { "Apple", "Banana", "Cherry" };
        Console.WriteLine("List after creation: " + string.Join(", ", list));

       
        Console.WriteLine("First element: " + list[0]);

       
        list[1] = "Blueberry"; 
        Console.WriteLine("List after update: " + string.Join(", ", list));

        list.Remove("Apple");  
        Console.WriteLine("List after deletion: " + string.Join(", ", list));

        Console.WriteLine();

        //4.Hashset
        HashSet<string> hashSet = new HashSet<string> { "Red", "Green", "Blue" };
        Console.WriteLine("HashSet after creation: " + string.Join(", ", hashSet));

     
        Console.WriteLine("Contains 'Green': " + hashSet.Contains("Green"));

      
        hashSet.Remove("Green");
        hashSet.Add("Yellow");  
        Console.WriteLine("HashSet after update: " + string.Join(", ", hashSet));

  
        hashSet.Remove("Blue");
        Console.WriteLine("HashSet after deletion: " + string.Join(", ", hashSet));

        Console.WriteLine();

        //5.SortedDictionary
        SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>
        {
            { 3, "Three" },
            { 1, "One" },
            { 2, "Two" }
        };
        Console.WriteLine("SortedDictionary after creation: ");
        foreach (var item in sortedDict) Console.WriteLine($"{item.Key}: {item.Value}");

      
        Console.WriteLine("Value for key 2: " + sortedDict[2]);

        sortedDict[2] = "Updated Two";  
        Console.WriteLine("SortedDictionary after update: ");
        foreach (var item in sortedDict) Console.WriteLine($"{item.Key}: {item.Value}");

        sortedDict.Remove(1);  
        Console.WriteLine("SortedDictionary after deletion: ");
        foreach (var item in sortedDict) Console.WriteLine($"{item.Key}: {item.Value}");

        Console.WriteLine();
         //6.Queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        Console.WriteLine("Queue after creation: " + string.Join(", ", queue));

        
        Console.WriteLine("Peek: " + queue.Peek());

        // Update (Dequeue and Enqueue)
        string dequeuedItem = queue.Dequeue();
        queue.Enqueue("Fourth");
        Console.WriteLine("Queue after update: " + string.Join(", ", queue));

        // Delete (Dequeue)
        queue.Dequeue();  // Removes the front item
        Console.WriteLine("Queue after deletion: " + string.Join(", ", queue));

        Console.WriteLine();
         //7.Stack
        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        Console.WriteLine("Stack after creation: " + string.Join(", ", stack));

        // Read (Peek)
        Console.WriteLine("Peek: " + stack.Peek());

        // Update (Pop and Push again)
        string poppedItem = stack.Pop();
        stack.Push("Fourth");
        Console.WriteLine("Stack after update: " + string.Join(", ", stack));

        // Delete (Pop)
        stack.Pop();
        Console.WriteLine("Stack after deletion: " + string.Join(", ", stack));

        Console.WriteLine();

        //8.LinkedList
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("First");
        linkedList.AddLast("Second");
        linkedList.AddLast("Third");
        Console.WriteLine("LinkedList after creation: " + string.Join(", ", linkedList));

        // Read (Traverse the list)
        foreach (var item in linkedList)
        {
            Console.WriteLine("Item in LinkedList: " + item);
        }

        // Update (Modify a node)
    LinkedListNode<string> node = linkedList.Find("Second");
        if (node != null) node.Value = "Updated Second";
        Console.WriteLine("LinkedList after update: " + string.Join(", ", linkedList));

        // Delete (Remove a node)
        linkedList.Remove("First");
        Console.WriteLine("LinkedList after deletion: " + string.Join(", ", linkedList));

        Console.WriteLine();

       //9.PriorityQueue
        PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();
    priorityQueue.Enqueue("Task 1", 1);
        priorityQueue.Enqueue("Task 2", 2);
        priorityQueue.Enqueue("Task 3", 3);
        Console.WriteLine("PriorityQueue after creation: ");
        foreach (var item in priorityQueue.UnorderedItems)
        {
            Console.WriteLine($"{item.Element}: {item.Priority}");
        }


Console.WriteLine("Peek: " + priorityQueue.Peek());


string priorityQueueDequeuedItem = priorityQueue.Dequeue();
priorityQueue.Enqueue("Task 4", 0); 
Console.WriteLine("PriorityQueue after update: ");
foreach (var item in priorityQueue.UnorderedItems)
{
    Console.WriteLine($"{item.Element}: {item.Priority}");
}

// Delete (Dequeue)
priorityQueue.Dequeue();
Console.WriteLine("PriorityQueue after deletion: ");
foreach (var item in priorityQueue.UnorderedItems)
{
    Console.WriteLine($"{item.Element}: {item.Priority}");
}
//10.Equality and ReferenceEqualityComparer
            var obj1 = new Person { Name = "John", Age = 30 };
            var obj2 = new Person { Name = "John", Age = 30 };

            bool areEqual = EqualityComparer<Person>.Default.Equals(obj1, obj2);
            Console.WriteLine("Are obj1 and obj2 equal:" + areEqual);

            // Using ReferenceEqualityComparer to compare references
            var obj3 = obj1;
            bool areReferencesEqual =Object.ReferenceEquals(obj1, obj3);
            Console.WriteLine("Are obj1 and obj3 references equal:" + areReferencesEqual);
        }
        public class Person
        {
            public string Name { get; set; }
           public  int Age { get; set; }
        }
    }
}
