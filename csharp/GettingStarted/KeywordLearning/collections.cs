using System;
using System.Collections.Generic;

namespace KeywordLearning
{
    public class CollectionDemo
    {
        public static void Demo()
        {
            Console.WriteLine("--------Example for List (Student Names)--------");

            // List example
            List<string> studentNames = new List<string> { "Alice", "Bob", "Charlie" };

            // Adding new students
            studentNames.Add("David");
            studentNames.Add("Emma");

            // Displaying all students
            Console.WriteLine("Student Names:");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }

            // Removing a student
            studentNames.Remove("Charlie");
            Console.WriteLine("After removing Charlie:");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------Example for Dictionary (Employee Salaries)--------");

            // Dictionary example
            Dictionary<string, decimal> employeeSalaries = new Dictionary<string, decimal>
            {
                { "Alice", 50000m },
                { "Bob", 60000m },
                { "Charlie", 70000m }
            };

            // Adding a new employee
            employeeSalaries["David"] = 55000m;

            // Displaying all employee salaries
            Console.WriteLine("Employee Salaries:");
            foreach (var employee in employeeSalaries)
            {
                Console.WriteLine($"{employee.Key}: ${employee.Value}");
            }

            // Updating a salary
            employeeSalaries["Bob"] = 62000m;
            Console.WriteLine("Updated salary for Bob: $" + employeeSalaries["Bob"]);

            Console.WriteLine("--------Example for Queue (Task Management)--------");

            // Queue example
            Queue<string> taskQueue = new Queue<string>();

            // Adding tasks
            taskQueue.Enqueue("Task 1: Prepare slides");
            taskQueue.Enqueue("Task 2: Review report");
            taskQueue.Enqueue("Task 3: Send emails");

            // Processing tasks
            Console.WriteLine("Tasks to process:");
            while (taskQueue.Count > 0)
            {
                Console.WriteLine("Processing: " + taskQueue.Dequeue());
            }

            Console.WriteLine("--------Example for Stack (Browser Navigation)--------");

            // Stack example
            Stack<string> navigationStack = new Stack<string>();

            // Simulating navigation
            navigationStack.Push("Homepage");
            navigationStack.Push("Products Page");
            navigationStack.Push("Product Details Page");

            // Navigating back
            Console.WriteLine("Current page: " + navigationStack.Pop());
            Console.WriteLine("Now on page: " + navigationStack.Peek());

            Console.WriteLine("--------Example for HashSet (Event RSVP)--------");

            // HashSet example
            HashSet<string> rsvpList = new HashSet<string> { "Alice", "Bob", "Charlie" };

            // Adding RSVP
            bool added = rsvpList.Add("David");
            Console.WriteLine("David added to RSVP: " + added);

            // Attempt to add duplicate
            added = rsvpList.Add("Alice");
            Console.WriteLine("Attempt to add Alice again: " + added);

            // Displaying RSVP list
            Console.WriteLine("RSVP List:");
            foreach (var name in rsvpList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------Example for LinkedList (To-Do List)--------");

            // LinkedList example
            LinkedList<string> toDoList = new LinkedList<string>();
            toDoList.AddLast("Wake up");
            toDoList.AddLast("Have breakfast");
            toDoList.AddLast("Go to work");

            // Adding a task at the beginning
            toDoList.AddFirst("Check phone");

            Console.WriteLine("To-Do List:");
            foreach (var task in toDoList)
            {
                Console.WriteLine(task);
            }

            // Removing a task
            toDoList.Remove("Go to work");
            Console.WriteLine("After removing 'Go to work':");
            foreach (var task in toDoList)
            {
                Console.WriteLine(task);
            }

            Console.WriteLine("--------Example for PriorityQueue (Support Tickets)--------");

            // PriorityQueue example
            PriorityQueue<string, int> supportTickets = new PriorityQueue<string, int>();

            // Adding tickets with priorities
            supportTickets.Enqueue("Critical Bug", 1);
            supportTickets.Enqueue("UI Issue", 3);
            supportTickets.Enqueue("Feature Request", 2);

            // Processing tickets by priority
            Console.WriteLine("Support Tickets Processed:");
            while (supportTickets.Count > 0)
            {
                Console.WriteLine(supportTickets.Dequeue());
            }
        }
    }
}
