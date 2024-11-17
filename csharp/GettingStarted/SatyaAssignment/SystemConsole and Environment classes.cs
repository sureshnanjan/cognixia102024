using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajProject
{
    internal class SystemConsole_and_Environment_classes
    {
        static void Main(string[] args)
        {
            // 1. Print the current Console background color
            Console.WriteLine($"Current Background Color: {Console.BackgroundColor}");

            // 2. Print the current Console foreground color
            Console.WriteLine($"Current Foreground Color: {Console.ForegroundColor}");

            // 3. Make the console beep 3 times
            for (int i = 0; i < 3; i++)
            {
                Console.Beep();
                System.Threading.Thread.Sleep(500); // Pause for 500ms before the next beep
            }

            // 4. Print the Machine Name
            Console.WriteLine($"Machine Name: {Environment.MachineName}");

            // 5. Print the Logged-in User Name
            Console.WriteLine($"Logged-in User Name: {Environment.UserName}");

            // 6. Print whether the Machine is 64-bit or not
            bool is64Bit = Environment.Is64BitOperatingSystem;
            Console.WriteLine($"Is the machine 64-bit? {is64Bit}");

            // Optional: Reset the console color to default
            Console.ResetColor();
        }
    }
}