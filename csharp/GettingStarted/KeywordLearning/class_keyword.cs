using System.Collections.Generic;
namespace KeywordLearning
{
    public class class_keyword
    {
        public static void DemonstrateKeywords()
        {
            // Variable declarations: 'int', 'string', 'var'
            int number = 10;
            string message = "Hello, C# in a separate method!";
            var list = new List<int> { 1, 2, 3 };

            // Displaying the message
            Console.WriteLine(message);

            // Control flow: 'if', 'else'
            if (number > 5)
            {
                Console.WriteLine("Number is greater than 5");
            }
            else
            {
                Console.WriteLine("Number is 5 or less");
            }

            // Looping: 'foreach'
            Console.WriteLine("Items in the list:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Exception handling: 'try', 'catch', 'finally'
            try
            {
                Console.WriteLine("Attempting to divide by zero...");
                int result = number / 0; // This will cause an exception
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            // Switch case example: 'switch', 'case', 'break', 'default'
            switch (number)
            {
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                default:
                    Console.WriteLine("Number is something else");
                    break;
            }
            //for each
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Object-oriented: 'new', 'class'
            Person person = new Person("Alice", 30);
            Console.WriteLine(person.GetInfo());
            Console.WriteLine("example for size of");

            // Using sizeof to get the size of primitive types
            Console.WriteLine("Size of int: " + sizeof(int));     // 4 bytes
            Console.WriteLine("Size of float: " + sizeof(float)); // 4 bytes
            Console.WriteLine("Size of double: " + sizeof(double)); // 8 bytes
            Console.WriteLine("Size of char: " + sizeof(char));   // 2 bytes
            Console.WriteLine("Size of bool: " + sizeof(bool));   // 1 byte
        }
    }

    // Simple Person class for demonstration
    public class Person
    {
        private string Name;
        private int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string GetInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    public delegate int Operation(int a, int b);

    public class Calculator
    {

        public int Add(int a, int b)
        {
            return a + b;
        }


        public int Subtract(int a, int b)
        {
            return a - b;
        }


        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    //override example
    // Base class
    public class Shape
    {
        // Virtual method that can be overridden in derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class: Circle
    public class Circle : Shape
    {
        // Overriding the Draw method in the Circle class
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class: Rectangle
    public class Rectangle : Shape
    {
        // Overriding the Draw method in the Rectangle class
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

    public class Collections
    {
        public static void excuteCollections()
        {
             //List
             Console.WriteLine("List");
             List<int> list1 = new List<int>();
             List<int> list2 = [1, 2, 3];
             List<int> list3=new List<int> { 1, 2, 3 };
             list1.Add(1);
             list1.Add(2);
             list1.Add(3);
             Console.WriteLine(list1.Count);    
             Console.WriteLine(list2.Count);
             Console.WriteLine(list3==list1);
             Console.WriteLine(list1.Capacity);
             //access
             Console.WriteLine(list2[0]);
             
        }
    }

}
