using System;
using System.Collections.Generic;

namespace KeywordLearning
{
    public class CollectionDemo
    {
        public static void Demo()
        {
            Console.WriteLine("--------Example for the Collection--------");

            Console.WriteLine("--------Example for the List-----------");
            // List
            List<int> numbers = new List<int> { 5, 10, 15 };
            List<string> colors = new List<string> { "Red", "Blue", "Green" };

            // Adding Elements
            colors.Add("Yellow");
            colors.Add("Purple");
            numbers.Add(20);
            numbers.Add(25);

            // Accessing Elements by Index
            Console.WriteLine("First color: " + colors[0]);
            Console.WriteLine("Second number: " + numbers[1]);

            // Iterating through a List
            Console.WriteLine("Numbers in the list:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Colors in the list:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // List Methods
            numbers.Sort();
            colors.Reverse();
            colors.Remove("Purple");

            Console.WriteLine("Colors after sorting and removal:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("--------Example for the Dictionary-----------");
            // Dictionary
            Dictionary<string, double> productPrices = new Dictionary<string, double>
            {
                { "Laptop", 899.99 },
                { "Phone", 499.99 },
                { "Tablet", 299.99 }
            };

            // Adding or updating an element
            productPrices["Smartwatch"] = 199.99;

            // Accessing Values
            Console.WriteLine("Price of Phone: " + productPrices["Phone"]);

            // Iterating through a Dictionary
            Console.WriteLine("Product prices:");
            foreach (var product in productPrices)
            {
                Console.WriteLine($"{product.Key}: ${product.Value}");
            }

            // Removing an Element
            productPrices.Remove("Tablet");
            Console.WriteLine("Tablet removed. Remaining products:");
            foreach (var product in productPrices)
            {
                Console.WriteLine($"{product.Key}: ${product.Value}");
            }

            Console.WriteLine("--------Example for the Queue-----------");
            // Queue
            Queue<string> customerQueue = new Queue<string>();

            // Enqueuing (adding) customers
            customerQueue.Enqueue("Alice");
            customerQueue.Enqueue("Bob");
            customerQueue.Enqueue("Charlie");

            // Accessing the first element
            Console.WriteLine("First in queue: " + customerQueue.Peek());

            // Dequeuing (removing) a customer
            customerQueue.Dequeue();
            Console.WriteLine("After dequeue, next in queue: " + customerQueue.Peek());

            // Checking remaining customers
            Console.WriteLine("Remaining in queue:");
            foreach (var customer in customerQueue)
            {
                Console.WriteLine(customer);
            }

            customerQueue.Clear();
            Console.WriteLine($"Queue count after clearing: {customerQueue.Count}");

            Console.WriteLine("--------Example for the Stack-----------");
            // Stack
            Stack<string> browserStack = new Stack<string>();

            // Pushing URLs onto the stack
            browserStack.Push("Homepage");
            browserStack.Push("Products Page");
            browserStack.Push("Contact Us Page");

            // Accessing the top URL
            Console.WriteLine("Current page: " + browserStack.Peek());

            // Popping (removing) the top URL
            browserStack.Pop();
            Console.WriteLine("After pop, current page: " + browserStack.Peek());

            browserStack.Clear();
            Console.WriteLine($"Stack count after clearing: {browserStack.Count}");

            Console.WriteLine("--------Example for the HashSet-----------");
            // HashSet
            HashSet<string> uniqueCities = new HashSet<string> { "New York", "Los Angeles", "Chicago" };

            // Attempting to add a duplicate
            bool added = uniqueCities.Add("New York");
            Console.WriteLine("Trying to add 'New York' again: " + added);

            // Iterating through HashSet
            Console.WriteLine("Cities in the HashSet:");
            foreach (var city in uniqueCities)
            {
                Console.WriteLine(city);
            }

            uniqueCities.Clear();
            Console.WriteLine($"HashSet count after clearing: {uniqueCities.Count}");

            Console.WriteLine("--------Example for the LinkedList-----------");
            // LinkedList
            LinkedList<string> taskList = new LinkedList<string>();
            taskList.AddLast("Wake up");
            taskList.AddLast("Brush teeth");
            taskList.AddLast("Go to work");

            Console.WriteLine("First task: " + taskList.First.Value);

            // Removing tasks
            taskList.RemoveFirst();
            Console.WriteLine("Tasks after RemoveFirst:");
            foreach (var task in taskList)
            {
                Console.WriteLine(task);
            }

            taskList.Clear();
            Console.WriteLine($"LinkedList count after clearing: {taskList.Count}");

            Console.WriteLine("--------Example for the PriorityQueue-----------");
            PriorityQueue<string, int> supportQueue = new PriorityQueue<string, int>();

            // Adding items with priorities
            supportQueue.Enqueue("High priority ticket", 1);
            supportQueue.Enqueue("Medium priority ticket", 2);
            supportQueue.Enqueue("Low priority ticket", 3);

            // Dequeue items by priority
            Console.WriteLine("Processing ticket: " + supportQueue.Dequeue());
            Console.WriteLine("Next ticket to process: " + supportQueue.Dequeue());

            supportQueue.Clear();
            Console.WriteLine($"PriorityQueue count after clearing: {supportQueue.Count}");
        }
    }
}
