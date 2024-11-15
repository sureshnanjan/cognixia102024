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
    // Abstract Class Example
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract void Display();
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine("This is a Circle.");
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; }
        public double Breadth { get; }

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public override double CalculateArea()
        {
            return Length * Breadth;
        }

        public override void Display()
        {
            Console.WriteLine("This is a Rectangle.");
        }
    }

    // Base, Virtual, and Override Keywords Example
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // IDisposable Example
    public class FileHandler : IDisposable
    {
        private StreamWriter _writer;

        public FileHandler(string fileName)
        {
            _writer = new StreamWriter(fileName);
        }

        public void WriteData(string data)
        {
            _writer.WriteLine(data);
            Console.WriteLine("Data written to file.");
        }

        public void Dispose()
        {
            _writer?.Dispose();
            Console.WriteLine("FileHandler disposed.");
        }
    }

    // Custom Interface and IComparable Example
    public interface IEmployee
    {
        string Name { get; set; }
        double Salary { get; set; }
        void DisplayDetails();
    }

    public class Employee : IEmployee, IComparable<Employee>
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee: {Name}, Salary: ${Salary}");
        }

        public int CompareTo(Employee other)
        {
            if (other == null) return 1;
            return this.Salary.CompareTo(other.Salary);
        }
    }

    // Extension Methods
    public static class Extensions
    {
        public static string FirstAndLastHyphenated(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            return str[0] + "-" + str[^1];
        }

        public static string FirstAndLastHyphenated(this Employee employee)
        {
            if (employee == null || string.IsNullOrEmpty(employee.Name)) return string.Empty;
            return employee.Name[0] + "-" + employee.Name[^1];
        }
    }
}
