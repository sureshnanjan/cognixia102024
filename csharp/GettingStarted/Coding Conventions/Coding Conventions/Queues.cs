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

namespace KeywordLearning;

public class QueueDemoGeneric
{
    public int CustomerId { get; set; }
    public string Name { get; set; }

    // Constructor for easy initialization
    public QueueDemoGeneric(int customerId, string name)
    {
        CustomerId = customerId;
        Name = name;
    }

    public override string ToString()
    {
        return $"ID: {CustomerId}, Name: {Name}";
    }
}

public class CustomerQueueManagement
{
    private Queue<QueueDemoGeneric> customerQueue = new Queue<QueueDemoGeneric>();

    // Create (Enqueue)
    public void EnqueueCustomer(int customerId, string name)
    {
        customerQueue.Enqueue(new QueueDemoGeneric(customerId, name));
        Console.WriteLine($"Customer '{name}' added to the queue.");
    }

    // Read (Peek and Display all)
    public void ViewQueue()
    {
        Console.WriteLine("\nAll Customers in Queue:");
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        foreach (var customer in customerQueue)
        {
            Console.WriteLine(customer);
        }
    }

    // Update (We cannot update elements directly in a Queue, so we will demonstrate a workaround)
    public void UpdateCustomer(int customerId, string newName)
    {
        bool customerFound = false;
        int queueCount = customerQueue.Count;

        // We cannot directly access and update elements in Queue, so we need to dequeue and enqueue again
        for (int i = 0; i < queueCount; i++)
        {
            QueueDemoGeneric currentCustomer = customerQueue.Dequeue();
            if (currentCustomer.CustomerId == customerId)
            {
                currentCustomer.Name = newName;
                Console.WriteLine($"Customer with ID {customerId} updated to '{newName}'.");
                customerFound = true;
            }
            customerQueue.Enqueue(currentCustomer);
        }

        if (!customerFound)
        {
            Console.WriteLine($"Customer with ID {customerId} not found.");
        }
    }

    // Delete (Dequeue)
    public void DequeueCustomer()
    {
        if (customerQueue.Count > 0)
        {
            QueueDemoGeneric customer = customerQueue.Dequeue();
            Console.WriteLine($"Customer '{customer.Name}' removed from the queue.");
        }
        else
        {
            Console.WriteLine("Queue is empty. No customer to dequeue.");
        }
    }

    // Search (Find by CustomerId)
    public void SearchCustomer(int customerId)
    {
        bool customerFound = false;

        foreach (var customer in customerQueue)
        {
            if (customer.CustomerId == customerId)
            {
                Console.WriteLine($"\nFound Customer: {customer}");
                customerFound = true;
                break;
            }
        }

        if (!customerFound)
        {
            Console.WriteLine($"Customer with ID {customerId} not found.");
        }
    }
}




