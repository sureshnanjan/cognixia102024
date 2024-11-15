using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Assignments
{
    public class GetJson
    {
        public static void SerializeWrite()
        {
            // Step 1: Create a sample object
            var person = new Person
            {
                Name = "John Doe",
                Age = 30,
                Occupation = "Software Developer"
            };

            // Step 2: Serialize the object to a JSON string
            string jsonString = JsonConvert.SerializeObject(person);
            Console.WriteLine("Serialized JSON String:");
            Console.WriteLine(jsonString);

            // Step 3: Define the file path
            string filePath = "person.json";

            // Step 4: Write the JSON string to a file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(jsonString);
            }

            Console.WriteLine($"\nJSON written to file: {filePath}");

            // Step 5: Read the JSON string from the file
            string readJsonString;
            using (StreamReader reader = new StreamReader(filePath))
            {
                readJsonString = reader.ReadToEnd();
            }

            Console.WriteLine("\nRead JSON String from File:");
            Console.WriteLine(readJsonString);

            // Optional: Deserialize the JSON string back to an object
            var deserializedPerson = JsonConvert.DeserializeObject<Person>(readJsonString);
            Console.WriteLine("\nDeserialized Object:");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}, Occupation: {deserializedPerson.Occupation}");
        }
    }

    // Sample Person class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
    }

}
