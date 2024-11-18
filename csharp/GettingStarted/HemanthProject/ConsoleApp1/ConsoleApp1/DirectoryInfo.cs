
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace HemanthProject
{
    public class DirectoryInfoDemo
    {

        public void display()
        {
            // Define the directory path where the text files will be created
            string directoryPath = @"C:\Testing\cognixia102024\csharp";

            // Create a DirectoryInfo object to check if the directory exists
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            // Check if the directory exists
            if (!directoryInfo.Exists)
            {
                // Create the directory if it doesn't exist
                directoryInfo.Create();
                Console.WriteLine($"Directory '{directoryPath}' created.");
            }
            else
            {
                Console.WriteLine($"Directory '{directoryPath}' already exists.");
            }

            // Define the file names
            string[] fileNames = new string[]
            {
            "Name.txt",
            "CompanyName.txt",
            "PlaceOfWork.txt"
            };

            // Define the content for each file
            string[] fileContents = new string[]
            {
            "Your Name: Person1",
            "Company Name: Ascendion.",
            "Place of Work: Tech Park"
            };
            Console.WriteLine(fileContents);

            // Create the files and write the content
            for (int i = 0; i < fileNames.Length; i++)
            {
                string filePath = Path.Combine(directoryPath, fileNames[i]);

                // Create and write to the file
                File.WriteAllText(filePath, fileContents[i]);

                // Get file info
                FileInfo fileInfo = new FileInfo(filePath);

                // Display file details
                Console.WriteLine($"\nDetails of file '{fileNames[i]}':");
                Console.WriteLine($"Full Path: {fileInfo.FullName}");
                Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
                Console.WriteLine($"File Size: {fileInfo.Length} bytes");
            }
        }
    }

}
