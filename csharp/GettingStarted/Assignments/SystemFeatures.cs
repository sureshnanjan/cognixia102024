using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class SystemFeatures
    {
        //1
        static void SystemDetails()
        {
            Console.WriteLine("=== System.Console and Environment Example ===");
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
        //2
        static void FileOperations()
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
        //3
        static void DisplayEnvironmentInfo()
        {
            Console.WriteLine("\n=== Environment Information ===");
            Console.WriteLine($"CommandLine: {Environment.CommandLine}");
            Console.WriteLine($"User Name: {Environment.UserName}");
            Console.WriteLine($"User Domain Name: {Environment.UserDomainName}");
            Console.WriteLine($"Machine Name: {Environment.MachineName}");
        }
        //4
        static void SimpleMethod(int number = 555, string str = "DEFAULT", bool option = true, params string[] remaining)
        {
            number = 100;
            str = "Changed in Method";
            Console.WriteLine($"Str in Method: {str}, Number in Method: {number}, The Bool Value is {option}");
            Console.WriteLine($"Trailing params count: {remaining.Length}");
        }

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
        //5
        // Overload for integers
        static int addNumbers(int input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload for floats
        static float addNumbers(float input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload for doubles
        static double addNumbers(double input1, double input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload for mixed types
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

        // Overload with additional input
        static string addNumbers(float input1, float input2, string message)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()} - {message}");
            return $"{input1 + input2} - {message}";
        }

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

        public static void execute()
        {
            SystemFeatures.SystemDetails();
            SystemFeatures.FileOperations();
            SystemFeatures.DisplayEnvironmentInfo();
            SystemFeatures.ParameterPassing();
            SystemFeatures.Overload();
        }
    }
}
