using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Assignment
{
    public class Assignment4
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public void Output(string[] args)
        {
            Assignment4 person = new Assignment4
            {
                Name = "Captain Linesh Mishra",
                Age = 21,
                Address = "Chennai, Tamilnadu, India"
            };

            // Step 2: Serialize the object to a JSON string
            string jsonString = JsonConvert.SerializeObject(person, Formatting.Indented);

            // Step 3: Write the JSON string to a file
            string filePath = "person.json";
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("JSON data has been written to the file.");

            // Step 4: Read the JSON string back from the file
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine("\nContents of the JSON file:");
            Console.WriteLine(fileContents);

            // Step 5: Deserialize the JSON string back to an object
            Assignment4 deserializedPerson = JsonConvert.DeserializeObject<Assignment4>(fileContents);
            Console.WriteLine("\nDeserialized object:");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}, Address: {deserializedPerson.Address}");
        }
    }
}
