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

namespace KeywordLearning.Assignment
{
    public class DelegateMethods
    {
        // Delegate declarations
        public delegate bool MyFirstDelegate(int x, int y, float a, float b);
        public delegate string MySecondDelegate(int x, float y);

        // Method matching MyFirstDelegate (returns bool)
        public bool CompareSums(int x, int y, float a, float b)
        {
            return (x + y) > (a + b);
        }

        // Method matching MySecondDelegate (returns string)
        public string FormatResult(int x, float y)
        {
            return $"The result is: {x * y}";
        }

        // Action delegate method (doesn't return anything, just performs an action)
        public void CompareSumsAction(int x, int y, float a, float b)
        {
            Console.WriteLine("ActionDelegate: " + ((x + y) > (a + b)));
        }

        // Func delegate method (returns a string)
        public string FormatResultFunc(int x, float y)
        {
            return $"FuncDelegate: {x + y}";
        }
    }
    
}
