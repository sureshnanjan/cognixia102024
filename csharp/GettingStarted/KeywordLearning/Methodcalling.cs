
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
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class MethodCalling
    {
        // Pass-by-value method
        public static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
            Console.WriteLine($"Inside squareVal (Pass-by-Value): {valParameter}");
        }

        // Pass-by-reference method
        public static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;
            Console.WriteLine($"Inside squareRef (Pass-by-Reference): {refParameter}");
        }

        // Method with 'out' parameter
        public static void GetValues(out int number, out string message)
        {
            number = 100; // Must initialize 'out' parameters
            message = "This is a message from GetValues with different input!";
        }

        // Method with 'in' parameter
       public  static void ShowValue(in int readOnlyValue)
        {
            // readOnlyValue = 10; // This will cause a compile-time error because 'in' parameters are read-only
            Console.WriteLine($"Inside ShowValue (Pass-by-ReadOnly): {readOnlyValue}");
        }

        public static void execute()
        {
            // Pass-by-value example with different input
            int value = 7;
            Console.WriteLine($"Before squareVal: {value}");
            squareVal(value);
            Console.WriteLine($"After squareVal: {value}");

            // Pass-by-reference example with different input
            int reference = 8;
            Console.WriteLine($"\nBefore squareRef: {reference}");
            squareRef(ref reference);
            Console.WriteLine($"After squareRef: {reference}");

            // Out parameters example with different input
            Console.WriteLine("\n=== Out Parameters Example ===");
            GetValues(out int number, out string message);
            Console.WriteLine($"Number: {number}, Message: {message}");

            // In parameter example with different input
            Console.WriteLine("\n=== In Parameters Example ===");
            int readOnlyValue = 250;
            ShowValue(in readOnlyValue);

            // Combining all
            Console.WriteLine("\n=== Summary ===");
            Console.WriteLine($"Final Value: {value}, Final Reference: {reference}, ReadOnlyValue: {readOnlyValue}");
        }
    }
}
