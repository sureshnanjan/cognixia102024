using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class GenericsDemo
    {
        // Fields
        string fname;
        int age;
        public void MyMethod(int a, string b) { }
        public void MyGenericMethod<T1, T2>(T1 a, T2 b)
        {
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            List<int> myints = new List<int>();
            List<float> myflo = new List<float>();

        }


        public void calling()
        {
            MyMethod(10, "string");
            MyGenericMethod<int, string>(10, "string");
            MyGenericMethod<bool, int>(true, 10);
            int[] ints = new int[10];
            MyCollection cooints = new MyCollection(ints);
            MyGenericCollection<int> mygentints = new MyGenericCollection<int>(ints);
        }
    }
    public class ListCollection{ 
        public static void Create(List<int> list, int item)
        {
            list.Add(item);
            Console.WriteLine($"Added {item} to the list.");
        }

        // Method to Read (display) all elements in the list
        public static void ReadList(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Console.WriteLine("List elements:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // Method to Update an element at a specific index
        public static void Update(List<int> list, int index, int newValue)
        {
            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            int oldValue = list[index];
            list[index] = newValue;
            Console.WriteLine($"Updated element at index {index} from {oldValue} to {newValue}.");
        }

        // Method to Delete an element by value
        public static void Delete(List<int> list, int value)
        {
            if (list.Remove(value))
            {
                Console.WriteLine($"Removed {value} from the list.");
            }
            else
            {
                Console.WriteLine($"{value} not found in the list.");
            }
        }

        // Method to Delete an element by index
        public static void DeleteAt(List<int> list, int index)
        {
            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            int removedValue = list[index];
            list.RemoveAt(index);
            Console.WriteLine($"Removed element {removedValue} at index {index}.");
        }


    }

    public class DictionaryCollection
    {
        public static void Create(Dictionary<int, string> dictionary, int key, string value)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
                Console.WriteLine($"Added ({key}, {value}) to the dictionary.");
            }
            else
            {
                Console.WriteLine($"Key {key} already exists with value '{dictionary[key]}'. Use Update to modify.");
            }
        }

        // Method to Read (display) all elements in the dictionary
        public static void ReadDictionary(Dictionary<int, string> dictionary)
        {
            if (dictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is empty.");
                return;
            }

            Console.WriteLine("Dictionary elements:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }

        // Method to Update an element by key
        public static void Update(Dictionary<int, string> dictionary, int key, string newValue)
        {
            if (dictionary.ContainsKey(key))
            {
                string oldValue = dictionary[key];
                dictionary[key] = newValue;
                Console.WriteLine($"Updated key {key} from '{oldValue}' to '{newValue}'.");
            }
            else
            {
                Console.WriteLine($"Key {key} not found. Use Create to add new key-value pair.");
            }
        }

        // Method to Delete an element by key
        public static void Delete(Dictionary<int, string> dictionary, int key)
        {
            if (dictionary.Remove(key))
            {
                Console.WriteLine($"Removed element with key {key}.");
            }
            else
            {
                Console.WriteLine($"Key {key} not found in the dictionary.");
            }
        }
    }
    public class MyCollection {
        int[] items;
        public MyCollection(int[] args)
        {
            this.items = args;
        }
        
    }

    public class MyGenericCollection<T> {
        T[] items;

        public MyGenericCollection(T[] args) {
            this.items = args;
        }
    }
}
