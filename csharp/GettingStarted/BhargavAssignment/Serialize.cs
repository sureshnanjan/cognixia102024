using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BhargavAssignment
{
    public class Serialize
    {
        public static void Main(string[] args)
        {
            // Step 2: Create an object of Raj and serialize it to a JSON string
            Raj person = new Raj
            {
                FirstName = "Raj Kiran",
                LastName = "Kadambalu",
                Age = 23
            };

            string jsonString = JsonConvert.SerializeObject(person);
            Console.WriteLine("Serialized JSON string: " + jsonString);

            // Step 3: Write the JSON string to a file
            string filePath = "person.json";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(jsonString);
            }

            Console.WriteLine("JSON string written to file.");

            // Step 4: Read the JSON string from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string fileContent = reader.ReadToEnd();
                Console.WriteLine("Read from file: " + fileContent);
            }
        }
    }

    public class Raj
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
