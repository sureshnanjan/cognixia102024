using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJECT
{
    public class Beep
    {
        public void sound()
        {
            // 1. Print the Background Color and Foreground Color
            Console.WriteLine("Background Color: " + Console.BackgroundColor);
            Console.WriteLine("Foreground Color: " + Console.ForegroundColor);

            // 2. Make the Console Beep 3 Times
            Console.WriteLine("Beeping 3 times...");
            for (int i = 0; i < 10; i++)
            {
                Console.Beep();
            }

            // 3. Print the Machine Name
            Console.WriteLine("Machine Name: " + Environment.MachineName);

            // 4. Print the Logged-in User Name
            Console.WriteLine("Logged-in User: " + Environment.UserName);

            // 5. Print whether the Machine is 64-bit or not
            if (Environment.Is64BitOperatingSystem)
            {
                Console.WriteLine("The machine is 64-bit.");
            }
            else
            {
                Console.WriteLine("The machine is not 64-bit.");
            }
        }
    }
}
