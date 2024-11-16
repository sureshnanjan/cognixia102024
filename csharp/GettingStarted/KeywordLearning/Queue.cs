using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Queue
    {
        public static void Main()
        {
            // Create
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");

            // Read (Peek without removing)
            Console.WriteLine("Front element: " + queue.Peek()); // Output: A

            // Update (Dequeue and enqueue a new element)
            queue.Dequeue(); // Removes A
            queue.Enqueue("C");

            // Delete
            queue.Dequeue(); // Removes B

            // Display all elements
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}