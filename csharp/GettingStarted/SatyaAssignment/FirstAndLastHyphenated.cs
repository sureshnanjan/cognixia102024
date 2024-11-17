using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyaAssignment
{
    internal class FirstAndLastHyphenated
    {
        public static void Main(string[] args)
        {
            // Demonstrating the String extension method
            string sampleText = "Rajkumar Kadambalu";
            Console.WriteLine("Original string: " + sampleText);
            Console.WriteLine("First and Last Name Hyphenated: " + sampleText.FirstAndLastHyphenated());

            // Demonstrating the custom class extension method for Employee
            Employee employee = new Employee("Rajkumar", "Kadambalu");
            Console.WriteLine("\nEmployee Name Hyphenated: " + employee.FirstAndLastHyphenated());
        }
    }

    // Extension method for String class
    public static class StringExtensions
    {
        public static string FirstAndLastHyphenated(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            string[] words = input.Split(' ');
            if (words.Length == 0)
                return string.Empty;

            // Return the first and last name hyphenated
            return words[0] + "-" + words[words.Length - 1];
        }
    }

    // Custom Employee class
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    // Extension method for custom Employee class
    public static class EmployeeExtensions
    {
        public static string FirstAndLastHyphenated(this Employee employee)
        {
            if (employee == null || string.IsNullOrEmpty(employee.FirstName) || string.IsNullOrEmpty(employee.LastName))
                return string.Empty;

            // Return the first and last name hyphenated for Employee object
            return employee.FirstName + "-" + employee.LastName;
        }
    }
}