using System;
using System.IO;
using Newtonsoft.Json;

namespace Assignments_CSharp
{
    public class NugetJson
    {
        // Define a class that you want to serialize
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

            // Constructor to initialize the person object
            public Person(string name, int age, string city)
            {
                Name = name;
                Age = age;
                City = city;
            }
        }

        // Method to serialize an object to a JSON string
        public static string SerializeObjectToJson(Person person)
        {
            // Use Newtonsoft.Json to serialize the object to a JSON string
            return JsonConvert.SerializeObject(person, Newtonsoft.Json.Formatting.Indented);
        }

        // Method to write the serialized JSON string to a file
        public static void WriteJsonToFile(string jsonContent, string filePath)
        {
            // Use File.WriteAllText to write the JSON string to the file
            File.WriteAllText(filePath, jsonContent);
        }

        // Method to read JSON content from a file
        public static string ReadJsonFromFile(string filePath)
        {
            // Use File.ReadAllText to read the file contents
            return File.ReadAllText(filePath);
        }

        // Method to deserialize a JSON string back to an object
        public static Person DeserializeJsonToObject(string jsonContent)
        {
            // Use Newtonsoft.Json to deserialize the JSON string to an object
            return JsonConvert.DeserializeObject<Person>(jsonContent);
        }
    }
}
