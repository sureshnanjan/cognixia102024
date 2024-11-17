using System;
using System.Collections.Generic;

namespace KeywordLearning
{
    public class CourseDetails
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
            CourseDetails course = new CourseDetails
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
