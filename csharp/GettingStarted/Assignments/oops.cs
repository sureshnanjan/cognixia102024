using System;
using System.IO;
using Newtonsoft.Json;

namespace Assignments
{
    // Abstract class and inheritance example
    abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping...");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    // Inheritance, base, this, virtual, and override example
    class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass.");
        }
    }

    class DerivedClass : BaseClass
    {
        private string message;

        public DerivedClass(string message)
        {
            this.message = message;
        }

        public override void DisplayMessage()
        {
            base.DisplayMessage();
            Console.WriteLine($"Message from DerivedClass: {message}");
        }
    }

    // Generic class example
    class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void DisplayPair()
        {
            Console.WriteLine($"Pair: {First}, {Second}");
        }
    }

    // Generic method in a non-generic class
    class SimpleClass
    {
        public void Display<T>(T item)
        {
            Console.WriteLine($"Item: {item}");
        }
    }

    // Array sort example
    class ArraySortExample
    {
        public void RunSortExample()
        {
            int[] numbers = { 5, 2, 8, 3, 1 };
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array:");
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }

    // Interfaces example
    interface IMovable
    {
        void Move();
    }

    interface IResizable
    {
        void Resize();
    }

    class Shape : IMovable, IResizable
    {
        public void Move()
        {
            Console.WriteLine("Shape is moving...");
        }

        public void Resize()
        {
            Console.WriteLine("Shape is resizing...");
        }
    }

    class Resource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Resource disposed.");
        }
    }
     class Person1
    {
        public string Name { get; set; }
    }

    // Extension methods
    static class Extensions
    {
        public static string FirstAndLastHyphenated(this string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input string cannot be null or empty.");
            return $"{input[0]}-{input[^1]}";
        }

        public static string FirstAndLastHyphenated(this Person1 person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));
            return $"{person.Name[0]}-{person.Name[^1]}";
        }
    }

   

    public class oops
    {
        public static void Demonstrateoops()
        {
            try
            {
                // Abstract class example
                Console.WriteLine("=== Abstract Class Example ===");
                Animal myDog = new Dog();
                myDog.MakeSound();
                myDog.Sleep();

                // Inheritance example
                Console.WriteLine("\n=== Inheritance Example ===");
                DerivedClass derived = new DerivedClass("Hello from DerivedClass!");
                derived.DisplayMessage();

                // Generic class example
                Console.WriteLine("\n=== Generic Class Example ===");
                var pair = new Pair<int, string>(1, "One");
                pair.DisplayPair();

                // Generic method example
                Console.WriteLine("\n=== Generic Method Example ===");
                var simple = new SimpleClass();
                simple.Display<int>(42);
                simple.Display<string>("Hello, Generics!");

                // Array sort example
                Console.WriteLine("\n=== Array Sort Example ===");
                var sorter = new ArraySortExample();
                sorter.RunSortExample();

                // Interface example
                Console.WriteLine("\n=== Interface Example ===");
                Shape shape = new Shape();
                shape.Move();
                shape.Resize();

                // IDisposable example
                Console.WriteLine("\n=== IDisposable Example ===");
                using (var resource = new Resource())
                {
                    Console.WriteLine("Using resource...");
                }

                // Extension methods
                Console.WriteLine("\n=== Extension Method Example ===");
                string text = "Hello";
                Console.WriteLine(text.FirstAndLastHyphenated());

                var person = new Person1 { Name = "John" };
                Console.WriteLine(person.FirstAndLastHyphenated());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
