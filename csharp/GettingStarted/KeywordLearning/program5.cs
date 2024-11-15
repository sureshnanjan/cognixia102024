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
    public static class Exercises
    {
        // 1. Abstract Classes
        public static void RunAbstractClassesEx()
        {
            try
            {
                Shape circle = new Circle(5);
                circle.DisplayShape();
                Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public abstract class Shape
        {
            public abstract double CalculateArea();

            public virtual void DisplayShape()
            {
                Console.WriteLine("This is a shape.");
            }
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

            public override void DisplayShape()
            {
                base.DisplayShape();
                Console.WriteLine($"This is a Circle with Radius: {Radius}");
            }
        }

        // 2. Inheritance
        public static void RunInheritanceEx()
        {
            try
            {
                BaseClass person = new DerivedClass("John", "Developer");
                person.Greet();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public class BaseClass
        {
            public string Name { get; set; }

            public BaseClass(string name)
            {
                Name = name;
            }

            public virtual void Greet()
            {
                Console.WriteLine($"Hello, my name is {Name}.");
            }
        }

        public class DerivedClass : BaseClass
        {
            public string Profession { get; set; }

            public DerivedClass(string name, string profession) : base(name)
            {
                Profession = profession;
            }

            public override void Greet()
            {
                base.Greet();
                Console.WriteLine($"I am a {Profession}.");
            }
        }

        // 3. Generics
        public static void RunGenericsMethodsEx()
        {
            try
            {
                GenericClass<int, string> instance = new GenericClass<int, string>(42, "Hello");
                instance.DisplayValues();

                DisplayGeneric<int>(100);
                DisplayGeneric<string>("Generics are powerful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public class GenericClass<T1, T2>
        {
            public T1 FirstValue { get; set; }
            public T2 SecondValue { get; set; }

            public GenericClass(T1 first, T2 second)
            {
                FirstValue = first;
                SecondValue = second;
            }

            public void DisplayValues()
            {
                Console.WriteLine($"First: {FirstValue}, Second: {SecondValue}");
            }
        }

        public static void DisplayGeneric<T>(T value)
        {
            Console.WriteLine($"Value: {value}");
        }

        // 4. Array.Sort
        public static void RunArraySortEx()
        {
            try
            {
                int[] group1 = { 5, 2, 1, 4, 3 };
                string[] group2 = { "Zebra", "Apple", "Monkey", "Banana" };

                Array.Sort(group1);
                Array.Sort(group2);

                Console.WriteLine("Sorted Group 1:");
                foreach (var item in group1) Console.Write(item + " ");

                Console.WriteLine("\nSorted Group 2:");
                foreach (var item in group2) Console.Write(item + " ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // 5. Interfaces
        public static void RunInterfaceEx()
        {
            try
            {
                IAnimal dog = new Dog();
                IAnimal cat = new Cat();

                dog.Speak();
                cat.Speak();

                using (var resource = new ManagedResource())
                {
                    resource.UseResource();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public interface IAnimal
        {
            void Speak();
        }

        public class Dog : IAnimal
        {
            public void Speak() => Console.WriteLine("Woof!");
        }

        public class Cat : IAnimal
        {
            public void Speak() => Console.WriteLine("Meow!");
        }

        public class ManagedResource : IDisposable
        {
            public void UseResource() => Console.WriteLine("Using resource...");
            public void Dispose() => Console.WriteLine("Releasing resource...");
        }

        // 6. Extension Methods
        public static void RunExtensionMethodsEx()
        {
            try
            {
                string example = "Hello from the extension method";
                Console.WriteLine(example.FirstAndLastHyphenated());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static string FirstAndLastHyphenated(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Invalid input";

            var words = input.Split(' ');
            if (words.Length < 2)
                return input;

            return $"{words[0]}-{words[^1]}";
        }
    }
}
