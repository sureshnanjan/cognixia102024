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

namespace KeywordLearning
{
    public static class CustomDelegates
    {
        // Custom delegate that takes 2 ints, 2 floats, and returns a bool
        public delegate bool IntFloatComparisonDelegate(int a, int b, float c, float d);

        // Custom delegate that takes an int and a float, and returns a string
        public delegate string IntFloatToStringDelegate(int x, float y);

        // Method for comparison (matches IntFloatComparisonDelegate)
        public static bool CompareValues(int a, int b, float c, float d)
        {
            // Compares whether the sum of the ints is greater than the sum of the floats
            return (a + b) > (c + d);
        }

        // Method for formatting (matches IntFloatToStringDelegate)
        public static string FormatValues(int x, float y)
        {
            return $"The integer is {x} and the float is {y:F2}.";
        }
    }

    public static class PredefinedDelegates
    {
        // Func delegate matching IntFloatComparisonDelegate
        public static readonly Func<int, int, float, float, bool> FuncCompare = (a, b, c, d) =>
        {
            return (a + b) > (c + d);
        };

        // Func delegate matching IntFloatToStringDelegate
        public static readonly Func<int, float, string> FuncFormat = (x, y) =>
        {
            return $"The integer is {x} and the float is {y:F2}.";
        };
    }
}
