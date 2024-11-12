/*
 
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
 
*/
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
