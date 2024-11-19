using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_CSharp
{
 

    // 1. Abstract Classes and Methods
    public abstract class Animal
    {
        public string Name { get; set; }

        // Abstract method that must be implemented in derived classes
        public abstract void Speak();
    }

    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }

        // Overriding the abstract method
        public override void Speak()
        {
            Console.WriteLine($"{Name} says Woof!");
        }
    }

    // 2. Inheritance Mechanism: Base, This, Virtual, Override
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw(); // Calls the base class Draw method
            Console.WriteLine("Drawing a Circle");
        }
    }

    // 3. Generics Classes and Methods
    public class GenericClass<T>
    {
        private T value;

        public GenericClass(T value)
        {
            this.value = value;
        }

        public T GetValue()
        {
            return value;
        }
    }

    // A method that accepts a generic type
    public class SimpleClass
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }
    }

    // 4. Interfaces
    public interface IComparableExample
    {
        int CompareTo(object obj);
    }

    public class Person1 : IComparableExample
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Person otherPerson = obj as Person;
            if (otherPerson != null)
                return this.Age.CompareTo(otherPerson.Age);
            else
                throw new ArgumentException("Object is not a Person");
        }
    }

    // IDisposable Interface Example
    public class Resource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Resource disposed");
        }
    }

    public class ResourceExample
    {
        public void UseResource()
        {
            using (var resource = new Resource())
            {
                Console.WriteLine("Using resource...");
            }
        }
    }

    // 5. Extension Methods for String and Custom Class
    public static class Extensions
    {
        public static string FirstAndLastHypenated(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            return $"{str[0]}-{str[str.Length - 1]}";
        }

        public static string FirstAndLastHypenated(this Person1 person1)
        {
            if (person1 == null) return string.Empty;
            return $"{person1.Name[0]}-{person1.Name[person1.Name.Length - 1]}";
        }
    }

}
