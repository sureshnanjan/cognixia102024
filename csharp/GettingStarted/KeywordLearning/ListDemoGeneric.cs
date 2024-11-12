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

namespace KeywordLearning;
  
public class ListDemoGeneric
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor for easy initialization
        public ListDemoGeneric(int id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Price: {Price:C}";
        }
    }

    public class ProductManagement
    {
        private List<ListDemoGeneric> products = new List<ListDemoGeneric>();

        // Create
        public void AddProduct(int id, string name, decimal price)
        {
            products.Add(new ListDemoGeneric(id, name, price));
            Console.WriteLine($"Product '{name}' added.");
        }

        // Read
        public void ViewAllProducts()
        {
            Console.WriteLine("\nAll Products:");
            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        // Update
        public void UpdateProduct(int id, string newName, decimal newPrice)
        {
        ListDemoGeneric product = products.Find(p => p.ID == id);
            if (product != null)
            {
                product.Name = newName;
                product.Price = newPrice;
                Console.WriteLine($"Product with ID {id} updated.");
            }
            else
            {
                Console.WriteLine($"Product with ID {id} not found.");
            }
        }

        // Delete
        public void DeleteProduct(int id)
        {
        ListDemoGeneric product = products.Find(p => p.ID == id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Product with ID {id} deleted.");
            }
            else
            {
                Console.WriteLine($"Product with ID {id} not found.");
            }
        }

        // Search
        public void SearchProduct(int id)
        {
        ListDemoGeneric product = products.Find(p => p.ID == id);
            if (product != null)
            {
                Console.WriteLine($"\nFound Product: {product}");
            }
            else
            {
                Console.WriteLine($"Product with ID {id} not found.");
            }
        }
    }

    

