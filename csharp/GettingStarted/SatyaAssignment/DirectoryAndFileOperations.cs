using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyaAssignment
{
    internal class DirectoryAndFileOperations
    {
        static void Main(string[] args)
        {
            // Define the directory path
            string directoryPath = @"C:\MyNewDirectory";

            // 1. Check if the directory exists
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if (!directoryInfo.Exists)
            {
                // 2. If directory does not exist, create the directory
                directoryInfo.Create();
                Console.WriteLine("Directory created: " + directoryPath);
            }
            else
            {
                Console.WriteLine("Directory already exists.");
            }

            // 3. Create 3 text files with your name, company name, and place of work
            string[] fileNames = { "MyName.txt", "CompanyName.txt", "PlaceOfWork.txt" };
            string[] content = { "Raj", "Ascendion", "New York" };

            for (int i = 0; i < fileNames.Length; i++)
            {
                string filePath = Path.Combine(directoryPath, fileNames[i]);
                // Write content to each file
                File.WriteAllText(filePath, content[i]);
                Console.WriteLine($"{fileNames[i]} created with content: {content[i]}");
            }

            // 4. Get the details of all the newly created files
            FileInfo[] files = directoryInfo.GetFiles();

            // 5. Display file information (Creation Time, Full Name, Size)
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"File: {file.FullName}");
                Console.WriteLine($"Creation Time: {file.CreationTime}");
                Console.WriteLine($"Size: {file.Length} bytes");
                Console.WriteLine();
            }

            // Optional: Wait for user input to close the console window
            Console.ReadLine();
        }
    }
}