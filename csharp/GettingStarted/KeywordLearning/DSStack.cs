using System;
using System.Collections.Generic;

namespace KeywordLearning
{
    public class DSStack
    {
        // Private stack to store items
        private Stack<int> itemStack;

        // Constructor to initialize the stack
        public DSStack()
        {
            itemStack = new Stack<int>();
        }

        // Method to push an item onto the stack
        public void Push(int item)
        {
            itemStack.Push(item);
            Console.WriteLine($"Item {item} pushed onto the stack.");
        }

        // Method to pop an item from the stack
        public void Pop()
        {
            if (itemStack.Count > 0)
            {
                int item = itemStack.Pop();
                Console.WriteLine($"Item {item} popped from the stack.");
            }
            else
            {
                Console.WriteLine("The stack is empty.");
            }
        }

        // Method to peek at the top item without removing it
        public void Peek()
        {
            if (itemStack.Count > 0)
            {
                int item = itemStack.Peek();
                Console.WriteLine($"Top item in the stack: {item}");
            }
            else
            {
                Console.WriteLine("The stack is empty.");
            }
        }

        // Method to display all items in the stack
        public void DisplayStack()
        {
            if (itemStack.Count == 0)
            {
                Console.WriteLine("The stack is empty.");
            }
            else
            {
                Console.WriteLine("Items in the stack (top to bottom):");
                foreach (var item in itemStack)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Method to check if the stack is empty
        public void IsEmpty()
        {
            if (itemStack.Count == 0)
            {
                Console.WriteLine("The stack is empty.");
            }
            else
            {
                Console.WriteLine("The stack is not empty.");
            }
        }

        // Method to run sample operations for the stack
        public void Output(string[] args)
        {
            DSStack myStack = new DSStack();

            // Push items onto the stack
            myStack.Push(10); // Pushing 10 onto the stack
            myStack.Push(20); // Pushing 20 onto the stack
            myStack.Push(30); // Pushing 30 onto the stack

            // Display the stack
            myStack.DisplayStack();

            // Peek at the top item
            myStack.Peek();

            // Pop an item from the stack
            myStack.Pop(); // Pops 30 from the stack

            // Display the stack after popping
            myStack.DisplayStack();

            // Check if the stack is empty
            myStack.IsEmpty();
        }
    }
}
