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
