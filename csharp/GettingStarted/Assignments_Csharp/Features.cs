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
            //Console.ResetColor();  // Reset to default colors

            // Make the console beep three times
            Console.WriteLine("\nMaking the console beep 3 times...");
            for (int i = 0; i < 3; i++)
            {
                Console.Beep(1000, 500);  // Frequency 1000 Hz, duration 500 ms
            }

            // Display machine and environment details
            Console.WriteLine("\nEnvironment Details:");
            Console.WriteLine($"Machine Name: {Environment.MachineName}");
            Console.WriteLine($"Logged-in User: {Environment.UserName}");
            Console.WriteLine($"Is 64-bit OS: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Operating System Version: {Environment.OSVersion}");
        }
    }
}
