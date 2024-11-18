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
using System.Xml;

namespace NEW_PROJECT
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

