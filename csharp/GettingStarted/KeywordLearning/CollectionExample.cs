using System;

using System.Collections;

namespace CollectionExample

{

    class Program

    {

        static void Main(string[] args)

        {

            // 1. List (Generic Collection)

            List<string> stringList = new List<string>();

            // CREATE: Add elements

            stringList.Add("Red");

            stringList.Add("Green");

            stringList.Add("Blue");

            Console.WriteLine("List after creation:");

            DisplayList(stringList);

            // UPDATE: Modify an element (index-based)

            stringList[1] = "Yellow";

            Console.WriteLine("\nList after updating index 1 to Yellow:");

            DisplayList(stringList);

            // READ-ONLY: Access an element (by index)

            Console.WriteLine("\nElement at index 2 (read-only): " + stringList[2]);

            // DELETE: Remove an element

            stringList.Remove("Red");

            Console.WriteLine("\nList after removing element 'Red':");

            DisplayList(stringList);


            // 2. ArrayList (Non-Generic Collection)

            ArrayList arrayList = new ArrayList();

            // CREATE: Add elements

            arrayList.Add(100);

            arrayList.Add(200);

            arrayList.Add(300);

            Console.WriteLine("\nArrayList after creation:");

            DisplayArrayList(arrayList);

            // UPDATE: Modify an element (index-based)

            arrayList[0] = 150;

            Console.WriteLine("\nArrayList after updating index 0 to 150:");

            DisplayArrayList(arrayList);

            // READ-ONLY: Access an element (by index)

            Console.WriteLine("\nElement at index 1 (read-only): " + arrayList[1]);

            // DELETE: Remove an element

            arrayList.Remove(200);

            Console.WriteLine("\nArrayList after removing element '200':");

            DisplayArrayList(arrayList);


            // 3. Queue (FIFO - First In First Out)

            Queue queue = new Queue();

            // CREATE: Add elements

            queue.Enqueue("Alice");

            queue.Enqueue("Bob");

            queue.Enqueue("Charlie");

            Console.WriteLine("\nQueue after creation:");

            DisplayQueue(queue);

            // UPDATE: Dequeue and then Enqueue (modify by re-adding new value)

            queue.Dequeue(); // Alice removed

            queue.Enqueue("David"); // New element added

            Console.WriteLine("\nQueue after dequeue and enqueue (replacing Alice with David):");

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

            stack.Push("Cat");

            stack.Push("Dog");

            stack.Push("Rabbit");

            Console.WriteLine("\nStack after creation:");

            DisplayStack(stack);

            // UPDATE: Pop an element and then Push a new one (to replace the popped)

            stack.Pop(); // Rabbit removed

            stack.Push("Lion"); // New element added

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

        static void DisplayList(List<string> list)

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

