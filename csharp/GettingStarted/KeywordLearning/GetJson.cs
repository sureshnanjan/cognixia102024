using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace KeywordLearning
{
    public class GetJson
    {
        public static void SerializeWrite()
        {
            // Step 1: Create a sample Company object with Employees
            var company = new Company
            {
                Name = "Tech Solutions Inc.",
                Founded = 2010,
                Employees = new List<Employee>
                {
                    new Employee { Name = "Alice", Age = 28, Position = "Software Engineer" },
                    new Employee { Name = "Bob", Age = 35, Position = "Project Manager" },
                    new Employee { Name = "Charlie", Age = 40, Position = "CEO" }
                }
            };

            // Step 2: Serialize the Company object to a JSON string
            string jsonString = JsonConvert.SerializeObject(company, Formatting.Indented);
            Console.WriteLine("Serialized JSON String:");
            Console.WriteLine(jsonString);

            // Step 3: Define the file path
            string filePath = "company.json";

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

            // Optional: Deserialize the JSON string back to a Company object
            var deserializedCompany = JsonConvert.DeserializeObject<Company>(readJsonString);
            Console.WriteLine("\nDeserialized Company Object:");
            Console.WriteLine($"Company Name: {deserializedCompany.Name}, Founded: {deserializedCompany.Founded}");
            Console.WriteLine("Employees:");
            foreach (var employee in deserializedCompany.Employees)
            {
                Console.WriteLine($" - {employee.Name}, {employee.Age} years old, {employee.Position}");
            }
        }
    }

    // Sample Company class
    class Company
    {
        public string Name { get; set; }
        public int Founded { get; set; }
        public List<Employee> Employees { get; set; }
    }

    // Sample Employee class
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
}
