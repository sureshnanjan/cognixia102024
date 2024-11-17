using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    public class SystemInfo
    {
        public  static void SystemDisplayInfo()
        {
            Console.BackgroundColor = ConsoleColor.Black;  
            Console.ForegroundColor = ConsoleColor.White;  
            Console.Clear();  

        
            for (int i = 0; i < 3; i++)
            {
                Console.Beep();  
            }

            
            Console.WriteLine($"Machine Name: {Environment.MachineName}");

        
            Console.WriteLine($"Logged-in User: {Environment.UserName}");

            
            bool is64Bit = Environment.Is64BitOperatingSystem;
            Console.WriteLine($"Is the machine 64-bit? {is64Bit}");

         
            Console.ResetColor();
        }
        public static void FileOperations()
        {
          
            string directoryPath = @"C:\MyDashboard";

       
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                Console.WriteLine($"Directory created: {directoryPath}");
            }
            else
            {
                Console.WriteLine("Directory already exists.");
            }

            string[] fileNames = { "Name.txt", "CompanyName.txt", "PlaceOfWork.txt" };
            string[] fileContents = { "John Doe", "TechCorp", "TechHub" };

            for (int i = 0; i < fileNames.Length; i++)
            {
                string filePath = Path.Combine(directoryPath, fileNames[i]);
                File.WriteAllText(filePath, fileContents[i]);
                Console.WriteLine($"Created file: {filePath}");
            }

           
            foreach (string file in fileNames)
            {
                string filePath = Path.Combine(directoryPath, file);
                FileInfo fileInfo = new FileInfo(filePath);

                Console.WriteLine($"File: {fileInfo.FullName}");
                Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
                Console.WriteLine($"Size: {fileInfo.Length} bytes");
                Console.WriteLine();
            }
        }
        public static void DisplayEnvironment()
        {
            Console.WriteLine($"CommandLine: {Environment.CommandLine}");
            Console.WriteLine($"UserName: {Environment.UserName}");
            Console.WriteLine($"UserDomainName: {Environment.UserDomainName}");
            Console.WriteLine($"MachineName: {Environment.MachineName}");
        }
        static void SimpleMethod(int number = 555, string str = "DEFAULT", bool option = true, params string[] remaining)
        {
           
            number = 100;
            str = "Changed in Method";

            Console.WriteLine($"Str in Method: {str} - Number in Method: {number} - The Bool Value is {option}");
            Console.WriteLine($"The all trailing params got here: {remaining.Length}");
        }
        public static void ParameterConventions()
        {
            
            SimpleMethod();

          
            SimpleMethod(100, "Positional", false, "Extra", "Args");

            SimpleMethod(str: "Named", number: 200, option: false, remaining: new string[] { "One", "Two" });
        }
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

      
    }
}
