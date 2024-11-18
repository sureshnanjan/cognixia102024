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
    public class DataType
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int DurationWeeks { get; set; }
        public List<string> Modules { get; set; }
        public List<string> EnrolledStudents { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Method to display the course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine("=== Course Details ===");
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Instructor: {Instructor}");
            Console.WriteLine($"Duration: {DurationWeeks} weeks");
            Console.WriteLine($"Start Date: {StartDate:dd MMM yyyy}");
            Console.WriteLine($"End Date: {EndDate:dd MMM yyyy}");

            Console.WriteLine("\nModules Covered:");
            foreach (var module in Modules)
            {
                Console.WriteLine($" - {module}");
            }

            Console.WriteLine("\nEnrolled Students:");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($" - {student}");
            }
        }

        // Static method to create and display a sample course
        public static void Display()
        {
            // Creating an instance of CourseDetails and setting values
            DataType course = new DataType
            {
                CourseName = "Advanced C# and .NET Core",
                Instructor = "John Doe",
                DurationWeeks = 8,
                StartDate = new DateTime(2024, 1, 10),
                EndDate = new DateTime(2024, 3, 10),
                Modules = new List<string> { "C# Advanced", "ASP.NET Core", "Entity Framework", "Web APIs" },
                EnrolledStudents = new List<string> { "Student A", "Student B", "Student C", "Student D" }
            };

            // Display the course details
            course.DisplayCourseDetails();
        }
    }
}
