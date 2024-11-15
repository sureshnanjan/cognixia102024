
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
*/using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;





namespace KeywordLearning
{
    public class GetJson
    {
        public static void SerializeWrite()
        {
            try
            {
                // Step 1: Create a sample Product object with different data
                var product = new Product
                {
                    Name = "Laptop",
                    Price = 999.99,
                    Category = "Electronics"
                };

                // Step 2: Serialize the object to a JSON string (with formatting)
                string jsonString = JsonConvert.SerializeObject(product); // Pretty-print JSON
                Console.WriteLine("Serialized JSON String:");
                Console.WriteLine(jsonString);

                // Step 3: Define the file path (using Path.Combine for better cross-platform support)
                string filePath = Path.Combine(Environment.CurrentDirectory, "product.json");

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

                // Optional: Deserialize the JSON string back to a Product object
                var deserializedProduct = JsonConvert.DeserializeObject<Product>(readJsonString);
                Console.WriteLine("\nDeserialized Object:");
                Console.WriteLine($"Name: {deserializedProduct.Name}, Price: {deserializedProduct.Price}, Category: {deserializedProduct.Category}");
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // Sample Product class
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }

}
