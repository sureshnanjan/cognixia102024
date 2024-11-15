
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
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    // Abstract class and inheritance example
    abstract class Vehicle
    {
        public abstract void StartEngine();

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started: Vroom Vroom!");
        }
    }

    // Inheritance, base, this, virtual, and override example
    class ParentClass
    {
        public virtual void PrintMessage()
        {
            Console.WriteLine("Message from ParentClass.");
        }
    }

    class ChildClass : ParentClass
    {
        private string _message;

        public ChildClass(string message)
        {
            _message = message;
        }

        public override void PrintMessage()
        {
            base.PrintMessage(); // Calling base class method
            Console.WriteLine($"Message from ChildClass: {_message}");
        }
    }

    // Generic class example for handling different types of items
    class Box<T>
    {
        public T Item { get; set; }

        public Box(T item)
        {
            Item = item;
        }

        public void ShowItem()
        {
            Console.WriteLine($"Box contains: {Item}");
        }
    }

    // Generic method in a non-generic class
    class UtilityClass
    {
        public void Print<T>(T item)
        {
            Console.WriteLine($"The value is: {item}");
        }
    }

    // Array sort example
    class ArraySorter
    {
        public void SortAndDisplay()
        {
            int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array:");
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }

    // Interfaces example
    interface IDriveable
    {
        void Drive();
    }

    interface IRefuelable
    {
        void Refuel();
    }

    class Truck : IDriveable, IRefuelable
    {
        public void Drive()
        {
            Console.WriteLine("Truck is driving on the highway.");
        }

        public void Refuel()
        {
            Console.WriteLine("Truck is being refueled.");
        }
    }

    class ResourceHandler : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Resource released.");
        }
    }

    // Person class for extension method example
    class Person
    {
        public string Name { get; set; }
    }

    // Extension methods
    static class StringExtensions
    {
        public static string ReverseString(this string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input string cannot be null or empty.");
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string NameInitials(this Person person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));
            return $"{person.Name[0]}-{person.Name[person.Name.Length - 1]}";
        }
    }

    public class OopsDemonstration
    {
        public static void DemonstrateOopsConcepts()
        {
            try
            {
                // Abstract class and Inheritance example
                Console.WriteLine("=== Abstract Class Example ===");
                Vehicle myCar = new Car();
                myCar.StartEngine();
                myCar.StopEngine();

                // Inheritance, base, this, virtual, and override example
                Console.WriteLine("\n=== Inheritance Example ===");
                ChildClass child = new ChildClass("Hello from ChildClass!");
                child.PrintMessage();

                // Generic class example
                Console.WriteLine("\n=== Generic Class Example ===");
                var box = new Box<string>("Gift Item");
                box.ShowItem();

                // Generic method example
                Console.WriteLine("\n=== Generic Method Example ===");
                var utility = new UtilityClass();
                utility.Print<int>(99);
                utility.Print<string>("Generic Methods are useful!");

                // Array Sort example
                Console.WriteLine("\n=== Array Sort Example ===");
                var sorter = new ArraySorter();
                sorter.SortAndDisplay();

                // Interface example
                Console.WriteLine("\n=== Interface Example ===");
                Truck truck = new Truck();
                truck.Drive();
                truck.Refuel();

                // IDisposable example
                Console.WriteLine("\n=== IDisposable Example ===");
                using (var resourceHandler = new ResourceHandler())
                {
                    Console.WriteLine("Using resource...");
                }

                // Extension Methods
                Console.WriteLine("\n=== Extension Methods Example ===");
                string text = "Hello";
                Console.WriteLine($"Reversed String: {text.ReverseString()}");

                var person = new Person { Name = "Alice" };
                Console.WriteLine($"Name Initials: {person.NameInitials()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
