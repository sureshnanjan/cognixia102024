using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhargavAssignment {
    // Abstract class and methods
    public abstract class Shape
    {
        // Abstract method - must be overridden in derived classes
        public abstract double CalculateArea();

        // Virtual method - can be overridden in derived classes
        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    // Derived class inheriting from Shape
    public class Circle : Shape
    {
        private double radius;

        // Constructor using "this" keyword to refer to the current object
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Override the abstract method from the base class
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Override the virtual method from the base class
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Using "base" to call the base class method
            Console.WriteLine("This is a circle with a radius of " + radius);
        }
    }

    // Another derived class inheriting from Shape
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a rectangle with a length of " + length + " and a width of " + width);
        }
    }

    // Main class to test Abstract Classes and Inheritance Mechanism
    internal class Abstract_Classes_and_Methods
    {
        public static void Main(string[] args)
        {
            Shape circle = new Circle(5); // Creating a Circle object
            Shape rectangle = new Rectangle(4, 6); // Creating a Rectangle object

            circle.DisplayInfo();
            Console.WriteLine("Area of Circle: " + circle.CalculateArea());

            rectangle.DisplayInfo();
            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
        }
    }
}
