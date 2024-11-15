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
using System.IO;

namespace KeywordLearning
{

    ///file name(11_CsharpAssignment_Day2)
    public class Program
    {
        public static void problem()
        {

            // Set the background and foreground color of the console
            Console.BackgroundColor = ConsoleColor.DarkBlue;  // Set background color to blue
            Console.ForegroundColor = ConsoleColor.Red;  // Set foreground color to white

            // Clear the console to apply the background color
            Console.Clear();

            // Make the console beep 3 times
            for (int i = 0; i < 3; i++)
            {
                Console.Beep();
            }

            // Print the machine name (hostname)
            string machineName = Environment.MachineName;
            Console.WriteLine("Machine Name: " + machineName);

            // Print the logged-in user name
            string userName = Environment.UserName;
            Console.WriteLine("Logged-in User: " + userName);

            // Print whether the machine is 64-bit or not
            bool is64Bit = Environment.Is64BitOperatingSystem;
            Console.WriteLine("Is the machine 64-bit? " + is64Bit);

            // Reset the console colors back to default
            Console.ResetColor();







        }

        public static void problem1()
        {
            // Step 1: Define the directory path
            string directoryPath = @"C:\ExampleDirectory";  // Change this path to your desired location

            // Step 2: Check if the directory exists
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);

            if (!dirInfo.Exists)
            {
                // If the directory does not exist, create it
                dirInfo.Create();
                Console.WriteLine("Directory created at: " + directoryPath);
            }
            else
            {
                Console.WriteLine("Directory already exists at: " + directoryPath);
            }

            // Step 3: Create 3 text files with content inside the newly created directory
            string[] fileNames = { "Name.txt", "Company.txt", "PlaceOfWork.txt" };
            string[] fileContents = { "John Doe", "ABC Corporation", "XYZ City" };

            for (int i = 0; i < fileNames.Length; i++)
            {
                string filePath = Path.Combine(directoryPath, fileNames[i]);
                File.WriteAllText(filePath, fileContents[i]);
                Console.WriteLine($"File {fileNames[i]} created at: {filePath}");
            }

            // Step 4: Retrieve and display details of all newly created files
            foreach (string fileName in fileNames)
            {
                string filePath = Path.Combine(directoryPath, fileName);
                FileInfo fileInfo = new FileInfo(filePath);

                Console.WriteLine("\nDetails for file: " + fileName);
                Console.WriteLine("Full Name: " + fileInfo.FullName);
                Console.WriteLine("Creation Time: " + fileInfo.CreationTime);
                Console.WriteLine("Size: " + fileInfo.Length + " bytes");
            }
        }



        public static void DisplayEnvironment()
        {
            // Get CommandLine
            string commandLine = Environment.CommandLine;
            // Get UserName
            string userName = Environment.UserName;
            // Get UserDomainName
            string userDomainName = Environment.UserDomainName;
            // Get MachineName
            string machineName = Environment.MachineName;

            // Display the information
            Console.WriteLine("Command Line: " + commandLine);
            Console.WriteLine("User Name: " + userName);
            Console.WriteLine("User Domain Name: " + userDomainName);
            Console.WriteLine("Machine Name: " + machineName);
        }
        public static void SimpleMethod(int number = 555, string str = "DEFAULT", bool option = true, params string[] remaining)
        {
            // Modifying the values inside the method
            number = 100;
            str = "Changed in Method";

            // Printing the values
            Console.WriteLine($"Str in Method: {str} - Number in Method: {number} - The Bool Value is: {option}");
            Console.WriteLine($"The all trailing params got here are: {remaining.Length}");
        }
        // Overload: add two integers
        public static int addNumbers(int input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload: add two floats
        public static float addNumbers(float input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload: add two doubles
        public static double addNumbers(double input1, double input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload: add an integer and a float
        public static float addNumbers(int input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload: add a float and an integer
        public static float addNumbers(float input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload: add two floats with an additional string input
        public static string addNumbers(float input1, float input2, string additionalInput)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()} and additional input of type {additionalInput.GetType()}");
            return $"Result of addition is {input1 + input2}. {additionalInput}";
        }
        // Method that demonstrates pass by value
        public static void squareVal(int valParameter)
        {
            valParameter *= valParameter;  // Modify local copy of valParameter
            Console.WriteLine($"Inside squareVal: valParameter = {valParameter}"); // Shows modified value locally
        }

        // Method that demonstrates pass by reference
        public static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;  // Modify the actual variable in the calling method
            Console.WriteLine($"Inside squareRef: refParameter = {refParameter}"); // Shows modified value inside method
        }
        // 'in' parameter: Read-only, passed by reference, but cannot be modified inside the method
        public static void SquareIn(in int val)
        {
            // val *= val;  // Error: Cannot modify an 'in' parameter inside the method
            Console.WriteLine($"Inside 'in' method: {val * val}");
        }

        // 'out' parameter: Must be assigned a value inside the method
        public static bool TryParseInt(string input, out int result)
        {
            bool success = int.TryParse(input, out result);
            if (success)
            {
                result *= 2;  // Assign a new value to the out parameter
            }
            else
            {
                result = 0;  // Assign a default value if parsing fails
            }
            return success;
        }

        // 'ref' parameter: Must be initialized before use and can be modified inside the method
        public static void DoubleValue(ref int value)
        {
            value *= 2;  // Modify the value inside the method
        }
        /// <summary>
        /// Represents a book with a title and price.
        /// </summary>
        public class Book
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Book"/> class.
            /// </summary>
            /// <param name="title">The title of the book.</param>
            /// <param name="price">The price of the book.</param>
            public Book(string title, decimal price)
            {
                Title = title;
                Price = price;
            }

            /// <summary>
            /// Gets or sets the title of the book.
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// Gets or sets the price of the book.
            /// </summary>
            public decimal Price { get; set; }
        }

        /// <summary>
        /// Represents the operations that can be performed in a bookstore.
        /// </summary>
        public class BookStoreCalculator
        {
            /// <summary>
            /// Calculates the total price of a list of books in a shopping cart.
            /// </summary>
            /// <param name="books">An array of <see cref="Book"/> objects.</param>
            /// <returns>The total price of all books in the cart.</returns>
            public decimal CalculateTotalPrice(Book[] books)
            {
                decimal total = 0;

                foreach (var book in books)
                {
                    total += book.Price;
                }

                return total;
            }
        }
    }
}
