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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJECT
{
    public class Environment_
    {
        public void display()
        {
            try
            {
                // Set the background and foreground color of the console
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Print a message to show the color change
                Console.Clear(); // To apply the background color change to the whole screen
                Console.WriteLine("Console background is dark blue and foreground is yellow.");

                // Beep 3 times
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                    System.Threading.Thread.Sleep(500); // Sleep for 500ms between beeps
                }

                // Print machine name
                string machineName = Environment.MachineName;
                Console.WriteLine($"Machine Name: {machineName}");

                // Print logged-in user name
                string userName = Environment.UserName;
                Console.WriteLine($"Logged-in User Name: {userName}");

                // Check if the machine is 64-bit or 32-bit
                bool is64Bit = Environment.Is64BitOperatingSystem;
                Console.WriteLine($"Is the machine 64-bit? {is64Bit}");

                // Reset the console colors to default
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
