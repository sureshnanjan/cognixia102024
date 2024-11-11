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

namespace TypeSystemDemo
{
    public class NumberPrinter
    {
        public void PrintNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("\nwhile loop\n");
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }

            Console.WriteLine("\ndo-while loop\n");
            i = 0;
            do
            {
                Console.WriteLine(numbers[i]);
                i++;
            } while (i < numbers.Length);

            Console.WriteLine("\nforeach loop\n");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nfor loop\n");
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

