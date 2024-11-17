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
    public class call_
    {
        public double CalculateRectangleArea(double width, double height)
        {
            // Calculate and return the area
            return width * height;
        }

        // The Main method, where the program execution starts
        public void display()
        {
            // Declare variables for the width and height of the rectangle
            double width = 5.0;
            double height = 10.0;

            // Call the CalculateRectangleArea method and pass the width and height
            double area = CalculateRectangleArea(width, height);

            // Display the result
            Console.WriteLine($"The area of the rectangle with width {width} and height {height} is: {area}");



        }
    }
}

