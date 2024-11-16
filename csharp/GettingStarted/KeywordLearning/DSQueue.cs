using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class DSQueue
    {
        // Private queue to store items
        private Queue<int> itemQueue;

        // Constructor to initialize the queue
        public DSQueue()
        {
            itemQueue = new Queue<int>();
        }

        // Method to enqueue (add) an item to the back of the queue
        public void Enqueue(int item)
        {
            itemQueue.Enqueue(item);
            Console.WriteLine($"Item {item} enqueued to the queue.");
        }

        // Method to dequeue (remove) an item from the front of the queue
        public void Dequeue()
        {
            if (itemQueue.Count > 0)
            {
                int item = itemQueue.Dequeue();
                Console.WriteLine($"Item {item} dequeued from the queue.");
            }
            else
            {
                Console.WriteLine("The queue is empty.");
            }
        }

        // Method to peek at the front item without removing it
        public void Peek()
        {
            if (itemQueue.Count > 0)
            {
                int item = itemQueue.Peek();
                Console.WriteLine($"Front item in the queue: {item}");
            }
            else
            {
                Console.WriteLine("The queue is empty.");
            }
        }

        // Method to display all items in the queue
        public void DisplayQueue()
        {
            if (itemQueue.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }
            else
            {
                Console.WriteLine("Items in the queue (front to back):");
                foreach (var item in itemQueue)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Method to check if the queue is empty
        public void IsEmpty()
        {
            if (itemQueue.Count == 0)
            {
                Console.WriteLine("The queue is empty.");
            }
            else
            {
                Console.WriteLine("The queue is not empty.");
            }
        }

        // Method to run sample operations for the queue
        public void Output(string[] args)
        {
            DSQueue myQueue = new DSQueue();

            // Enqueue items into the queue
            myQueue.Enqueue(10); // Enqueue 10
            myQueue.Enqueue(20); // Enqueue 20
            myQueue.Enqueue(30); // Enqueue 30

            // Display the queue
            myQueue.DisplayQueue();

            // Peek at the front item
            myQueue.Peek();

            // Dequeue an item from the queue
            myQueue.Dequeue(); // Dequeue 10

            // Display the queue after dequeuing
            myQueue.DisplayQueue();

            // Check if the queue is empty
            myQueue.IsEmpty();
        }
    }
}

