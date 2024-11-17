using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class StackCRUD<T>
    {
        private List<T> stack;

        // Constructor to initialize the stack
        public StackCRUD()
        {
            stack = new List<T>();
        }

        // Create: Push an element onto the stack
        public void Push(T item)
        {
            stack.Add(item);
            Console.WriteLine($"Pushed: {item}");
        }

        // Read: View the top element without removing it
        public T Peek()
        {
            if (stack.Count > 0)
            {
                return stack[stack.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        // Update: Replace the element at the top of the stack
        public void Update(T item)
        {
            if (stack.Count > 0)
            {
                stack[stack.Count - 1] = item;
                Console.WriteLine($"Updated top element to: {item}");
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        // Delete: Pop an element from the stack
        public T Pop()
        {
            if (stack.Count > 0)
            {
                T item = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                Console.WriteLine($"Popped: {item}");
                return item;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        // Display all elements in the stack
        public void DisplayStack()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine("Stack elements:");
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }


}
