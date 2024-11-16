using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Stack
    {
        public static void Main()
        {
            // Create
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");

            // Read (Peek without removing)
            Console.WriteLine("Top element: " + stack.Peek()); // Output: B

            // Update (Pop and then push a new element)
            stack.Pop(); // Removes B
            stack.Push("C");

            // Delete
            stack.Pop(); // Removes C

            // Display all elements
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}