using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Csharp
{
    public class Features
    {
        public static void SystemConsole()
        {
            // Modify console background and foreground colors
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();  // Apply the background color to the entire console
            Console.WriteLine("Console Colors Modified!");

            // Make the console beep three times
            Console.WriteLine("\nMaking the console beep 3 times...");
            for (int i = 0; i < 3; i++)
            {
                Console.Beep();  // Frequency 1000 Hz, duration 500 ms
            }

            // Display machine and environment details
            Console.WriteLine("\nEnvironment Details:");
            Console.WriteLine($"Machine Name: {Environment.MachineName}");
            Console.WriteLine($"Logged-in User: {Environment.UserName}");
            Console.WriteLine($"Is 64-bit OS: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Operating System Version: {Environment.OSVersion}");
        }
        public static void FileCreate()
        {
            string directoryPath = @"C:\DemoDirectory";
            string[] fileNames = { "YourName.txt", "CompanyName.txt", "PlaceOfWork.txt" };
            string[] fileContents = { "Sameera Mohamed", "Cognixia", "Chennai" };

            // Check if the directory exists
            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            if (!directory.Exists)
            {
                Console.WriteLine($"Directory does not exist. Creating directory at: {directory.FullName}");
                directory.Create(); // Create directory
            }
            else
            {
                Console.WriteLine($"Directory already exists at: {directory.FullName}");
            }

            // Create text files in the directory
            for (int i = 0; i < fileNames.Length; i++)
            {
                string filePath = Path.Combine(directory.FullName, fileNames[i]);
                File.WriteAllText(filePath, fileContents[i]); // Create and write content to file
                Console.WriteLine($"Created file: {fileNames[i]}");
            }

            Console.WriteLine("\nDetails of the newly created files:");
            // Get details of the newly created files
            foreach (FileInfo file in directory.GetFiles())
            {
                Console.WriteLine($"File Name: {file.Name}");
                Console.WriteLine($"Full Path: {file.FullName}");
                Console.WriteLine($"Creation Time: {file.CreationTime}");
                Console.WriteLine($"Size: {file.Length} bytes");
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
