using System;
using System.Collections.Generic;

namespace Mainfile
{
    public class QueueExample
    {
        private Queue<string> queue = new Queue<string>();

        public void Execute()
        {
            // Create
            queue.Enqueue("Item 1");
            queue.Enqueue("Item 2");
            Console.WriteLine("Items added to queue.");

            // Read
            Console.WriteLine("Items in the queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Update (dequeue and enqueue)
            string frontItem = queue.Dequeue();
            queue.Enqueue("Updated " + frontItem);
            Console.WriteLine("Updated front item.");

            // Delete
            queue.Dequeue();
            Console.WriteLine("Removed front item from queue.");
        }
    }
}