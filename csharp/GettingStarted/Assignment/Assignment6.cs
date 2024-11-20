using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Assignment6
    {
        // this code is for where we will use Console to modify the background and foreground colors,
        // beep the console, and display system information like machine name, logged-in username,
        // and architecture type (64-bit or not). The Environment class will help us fetch additional system information.

        public void Output1(string[] args)
        {
            try
            {
                // Set Console Background and Foreground Colors
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear(); // Apply the background color change

                // Make the Console beep 3 times
                Console.Beep(1500, 500);  // Beep with frequency 500Hz for 500 milliseconds
                Console.Beep(2000, 500); // Beep with frequency 1000Hz for 500 milliseconds
                Console.Beep(2500, 500); // Beep with frequency 1500Hz for 500 milliseconds

                // Print Machine Name
                string machineName = Environment.MachineName;
                Console.WriteLine($"Machine Name: {machineName}");

                // Print Logged in User Name
                string userName = Environment.UserName;
                Console.WriteLine($"Logged-in User: {userName}");

                // Check if the machine is 64-bit
                bool is64Bit = Environment.Is64BitOperatingSystem;
                Console.WriteLine($"Is the system 64-bit? {is64Bit}");

                // Reset Console Colors
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        //Here We will use the DirectoryInfo class to check for directory existence and create it,
        //and the File class to create files, write content, and retrieve their details.
        public void Output2(string[] args)
        {
            try
            {
                // Directory path
                string directoryPath = @"C:\MyFiles";

                // Check if directory exists, if not create it
                DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                    Console.WriteLine("Directory created: " + directoryPath);
                }

                // Create 3 text files with details
                string[] fileNames = { "Name.txt", "CompanyName.txt", "PlaceOfWork.txt" };
                string[] fileContents = { "Linesh Mishra", "Ascendion Private Limited", "Sholinganalur, Chennai" };

                for (int i = 0; i < fileNames.Length; i++)
                {
                    string filePath = Path.Combine(directoryPath, fileNames[i]);
                    File.WriteAllText(filePath, fileContents[i]);
                    Console.WriteLine($"File Created: {filePath}");
                }

                // Get and display file details
                foreach (var fileName in fileNames)
                {
                    string filePath = Path.Combine(directoryPath, fileName);
                    FileInfo fileInfo = new FileInfo(filePath);

                    Console.WriteLine($"File: {filePath}");
                    Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
                    Console.WriteLine($"Full Name: {fileInfo.FullName}");
                    Console.WriteLine($"Size: {fileInfo.Length} bytes");
                    Console.WriteLine("---------------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        //Here we will understand how to pass parameters, including optional, positional, and named parameters,
        //as well as the params keyword. Here's the example method you provided.

        static void SimpleMethod(int number = 555, string str = "DEFAULT", bool option = true, params string[] remaining)
        {
            number = 100;
            str = "Changed in Method";
            Console.WriteLine($"Str in Method: {str} - Number in Method: {number} The Bool Value is {option}");
            Console.WriteLine($"The all trailing params got here is {remaining.Length}");
        }
        public void Output3(string[] args)
        {
            try
            {
                // No arguments
                SimpleMethod();

                // Positional arguments followed by a sequence of remaining arguments
                SimpleMethod(200, "Hello", true, "arg1", "arg2", "arg3");

                // Calling by Named Parameter convention
                SimpleMethod(str: "Custom String", number: 500);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        // Here we will create overloads for the addNumbers method to handle different types of inputs.
        public static int addNumbers(int input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        public static float addNumbers(float input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        public static double addNumbers(double input1, double input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        public static dynamic addNumbers(int input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        public static string addNumbers(float input1, float input2, string additionalInfo)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return $"{input1 + input2} - {additionalInfo}";
        }

        public void Output4(string[] args)
        {
            try
            {
                Console.WriteLine(addNumbers(0, 0));
                Console.WriteLine(addNumbers(1.0f, 1.0f));
                Console.WriteLine(addNumbers(1.0, 1.0));
                Console.WriteLine(addNumbers(1, 1.0f));
                Console.WriteLine(addNumbers(1.0f, 1));
                Console.WriteLine(addNumbers(1.0f, 1.0f, "This is with additional inputs"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
