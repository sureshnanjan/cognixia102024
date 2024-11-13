using System;
using System.Collections;

namespace CollectionExample
{
    public class Program
    {
        public void Main(string[] args)
        {
            // 1. List (Generic Collection)
            List<int> intList = new List<int>();

            // CREATE: Add elements
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            Console.WriteLine("List after creation:");
            DisplayList(intList);

            // UPDATE: Modify an element (index-based)
            intList[1] = 25;
            Console.WriteLine("\nList after updating index 1 to 25:");
            DisplayList(intList);

            // READ-ONLY: Access an element (by index)
            Console.WriteLine("\nElement at index 2 (read-only): " + intList[2]);

            // DELETE: Remove an element
            intList.Remove(20);
            Console.WriteLine("\nList after removing element 20:");
            DisplayList(intList);


            // 2. ArrayList (Non-Generic Collection)
            ArrayList arrayList = new ArrayList();

            // CREATE: Add elements
            arrayList.Add("Apple");
            arrayList.Add("Banana");
            arrayList.Add("Cherry");
            Console.WriteLine("\nArrayList after creation:");
            DisplayArrayList(arrayList);

            // UPDATE: Modify an element (index-based)
            arrayList[1] = "Blueberry";
            Console.WriteLine("\nArrayList after updating index 1 to Blueberry:");
            DisplayArrayList(arrayList);

            // READ-ONLY: Access an element (by index)
            Console.WriteLine("\nElement at index 2 (read-only): " + arrayList[2]);

            // DELETE: Remove an element
            arrayList.Remove("Apple");
            Console.WriteLine("\nArrayList after removing element 'Apple':");
            DisplayArrayList(arrayList);


            // 3. Queue (FIFO - First In First Out)
            Queue queue = new Queue();

            // CREATE: Add elements
            queue.Enqueue("John");
            queue.Enqueue("Mary");
            queue.Enqueue("David");
            Console.WriteLine("\nQueue after creation:");
            DisplayQueue(queue);

            // UPDATE: Dequeue and then Enqueue (modify by re-adding new value)
            queue.Dequeue(); // John removed
            queue.Enqueue("James"); // New element added
            Console.WriteLine("\nQueue after dequeue and enqueue (replacing John with James):");
            DisplayQueue(queue);

            // READ-ONLY: Peek at the first element
            Console.WriteLine("\nPeek at the first element in the queue (read-only): " + queue.Peek());

            // DELETE: Dequeue an element
            queue.Dequeue();
            Console.WriteLine("\nQueue after removing one element (dequeue):");
            DisplayQueue(queue);


            // 4. Stack (LIFO - Last In First Out)
            Stack stack = new Stack();

            // CREATE: Push elements onto the stack
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            Console.WriteLine("\nStack after creation:");
            DisplayStack(stack);

            // UPDATE: Pop an element and then Push a new one (to replace the popped)
            stack.Pop(); // Third removed
            stack.Push("Fourth"); // New element added
            Console.WriteLine("\nStack after popping and pushing a new element:");
            DisplayStack(stack);

            // READ-ONLY: Peek at the top element
            Console.WriteLine("\nPeek at the top element in the stack (read-only): " + stack.Peek());

            // DELETE: Pop an element
            stack.Pop();
            Console.WriteLine("\nStack after popping one element:");
            DisplayStack(stack);
        }

        // Method to display List
        public void DisplayList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // Method to display ArrayList
        static void DisplayArrayList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        // Method to display Queue
        static void DisplayQueue(Queue queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        // Method to display Stack
        static void DisplayStack(Stack stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
