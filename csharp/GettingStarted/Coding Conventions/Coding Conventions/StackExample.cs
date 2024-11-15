using System;
using System.Collections.Generic;

namespace Mainfile
{
    public class StackExample
    {
        private Stack<string> stack = new Stack<string>();

        public void Execute()
        {
            // Create
            stack.Push("Item 1");
            stack.Push("Item 2");
            Console.WriteLine("Items added to stack.");

            // Read
            Console.WriteLine("Items in the stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Update (peek and replace)
            string topItem = stack.Pop();
            stack.Push("Updated " + topItem);
            Console.WriteLine("Updated top item.");

            // Delete
            stack.Pop();
            Console.WriteLine("Removed top item from stack.");
        }
    }
}