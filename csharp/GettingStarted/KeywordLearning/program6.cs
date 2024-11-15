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
using System.IO;

namespace KeywordLearning
{
    public class SystemFeatures
    {
        //1. System Console and Environment Example
        public static void SystemDetails()
        {
            Console.WriteLine("=== System.Console and Environment ===");
            // Change console background and foreground colors
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear(); // To apply the new background color
            Console.WriteLine("Console colors updated!");

            // Beep sound 3 times
            for (int i = 0; i < 3; i++)
            {
                Console.Beep();
            }

            // Print machine details
            Console.WriteLine($"Machine Name: {Environment.MachineName}");
            Console.WriteLine($"Logged In User: {Environment.UserName}");
            Console.WriteLine($"Is 64-Bit OS: {Environment.Is64BitOperatingSystem}");
        }

        //2. Directory and File Operations
        public static void FileOperations()
        {
            Console.WriteLine("\n=== Directory and File Operations ===");

            string directoryPath = Path.Combine(Environment.CurrentDirectory, "MyDirectory");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory created: {directoryPath}");
            }
            else
            {
                Console.WriteLine("Directory already exists.");
            }

            // Create text files
            string[] fileNames = { "Name.txt", "Company.txt", "Place.txt" };
            string[] fileContents = { "Your Name", "Your Company", "Your Place" };

            for (int i = 0; i < fileNames.Length; i++)
            {
                string filePath = Path.Combine(directoryPath, fileNames[i]);
                File.WriteAllText(filePath, fileContents[i]);
                Console.WriteLine($"File created: {filePath}");
            }

            // Display file details
            var directoryInfo = new DirectoryInfo(directoryPath);
            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine($"\nFile: {file.Name}");
                Console.WriteLine($"Creation Time: {file.CreationTime}");
                Console.WriteLine($"Full Name: {file.FullName}");
                Console.WriteLine($"Size: {file.Length} bytes");
            }
        }

        //3. Display Environment Information
        public static void DisplayEnvironmentInfo()
        {
            Console.WriteLine("\n=== Environment Information ===");
            Console.WriteLine($"CommandLine: {Environment.CommandLine}");
            Console.WriteLine($"User Name: {Environment.UserName}");
            Console.WriteLine($"User Domain Name: {Environment.UserDomainName}");
            Console.WriteLine($"Machine Name: {Environment.MachineName}");
        }

        //4. Parameter Passing Example
        public static void ParameterPassing()
        {
            Console.WriteLine("\n=== Parameter Passing Example ===");

            // No arguments
            SimpleMethod();

            // Positional arguments
            SimpleMethod(10, "Hello", false, "Extra1", "Extra2");

            // Named arguments
            SimpleMethod(str: "Using Named", remaining: new string[] { "Extra3", "Extra4" });
        }

        // Method to show parameter passing
        static void SimpleMethod(int number = 555, string str = "DEFAULT", bool option = true, params string[] remaining)
        {
            number = 100;
            str = "Changed in Method";
            Console.WriteLine($"Str in Method: {str}, Number in Method: {number}, The Bool Value is {option}");
            Console.WriteLine($"Trailing params count: {remaining.Length}");
        }

        //5. Overloaded Methods
        public static void Overload()
        {
            Console.WriteLine("\n=== Overloaded Methods Example ===");
            addNumbers(0, 0);
            addNumbers(1.0f, 1.0f);
            addNumbers(1.0, 1.0);
            addNumbers(1, 1.0f);
            addNumbers(1.0f, 1);
            addNumbers(1.0f, 1.0f, "This is with additional inputs");
        }

        // Overloaded addNumbers method for different types
        static int addNumbers(int input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        static float addNumbers(float input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        static double addNumbers(double input1, double input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        static float addNumbers(int input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        static float addNumbers(float input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        static string addNumbers(float input1, float input2, string message)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()} - {message}");
            return $"{input1 + input2} - {message}";
        }

        // Execute all tasks
        public static void execute()
        {
            SystemDetails();
            FileOperations();
            DisplayEnvironmentInfo();
            ParameterPassing();
            Overload();
        }
    }
}
