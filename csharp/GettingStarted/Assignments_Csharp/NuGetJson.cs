using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Assignments_Csharp
{
    /// <summary>
    /// Represents the details of an employee in Json format.
    /// </summary>
    public class NuGetJson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Method to serialize multiple employee details to a JSON file.
        /// </summary>
        public static void GetJson()
        {
            // Create an instance of the NuGetJson class
            var employeeDetails = new List<NuGetJson> {
                new NuGetJson { Name = "Sameera", Age = 21 },
                new NuGetJson { Name = "Anu", Age = 20 },
                new NuGetJson { Name = "Sravya", Age = 22 },
                new NuGetJson { Name = "Saritha", Age = 19 }

            };

            // Serialize the object to a JSON string
            string jsonString = JsonConvert.SerializeObject(employeeDetails);

            // Write the JSON string to a file
            string filePath = @"employeeDetails.json";
            File.WriteAllText(filePath, jsonString);

            // Read the contents of the JSON file
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("\nContents of the file in Json:");
            Console.WriteLine(fileContent);
        }
    }
}
