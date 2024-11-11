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

namespace TypeSystemDemo
{
        public class Condition
        {
            // Method for If-Else condition
            public void CheckIfElse()
            {
                int number = 10;
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else
                {
                    Console.WriteLine("The number is not positive.");
                }
            }

            // Method for Switch-Case condition
            public void CheckSwitchCase()
            {
                int dayOfWeek = 3; // 1 = Sunday, 2 = Monday, ..., 7 = Saturday

                switch (dayOfWeek)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid day");
                        break;
                }
            }

            // Method for Ternary condition
            public void CheckTernary()
            {
                int number1 = 5;
                string result = (number1 > 0) ? "Positive" : "Non-positive";
                Console.WriteLine(result);
            }
        }
    
}
