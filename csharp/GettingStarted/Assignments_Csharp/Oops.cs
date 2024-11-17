using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Csharp
{
    /// <summary>
    /// Represents an abstract base class for shapes.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Abstract method to calculate the area of a shape.
        /// </summary>
        /// <returns>The area of the shape.</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Concrete method to display the calculated area of the shape.
        /// Can be overridden in derived classes.
        /// </summary>
        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }

    /// <summary>
    /// Represents a circle, derived from the Shape class.
    /// </summary>
    public class Circles : Shape
    {
        public double Radius { get; set; }

        //contructor
        public Circles(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be a positive value.");
            }
            Radius = radius;
        }

        // Override the abstract method calculateArea
        public override double CalculateArea()
        {
            try
            {
                return Math.PI * Radius * Radius;
            }
            catch (OverflowException ex)
            {
                throw new InvalidOperationException("Overflow occurred while calculating the area.", ex);
            }
        }

        // Overrides the base DisplayArea method
        public override void DisplayArea()
        {
            try
            {
                base.DisplayArea();
                Console.WriteLine($"Area of Circle: {CalculateArea()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while displaying the area: {ex.Message}");
            }
        }
    }
    public class Oops 
    { 
        public static void AbstractMethod()
        {
            try
            {
                // Test with valid radius
                Shape shape = new Circles(5);
                shape.DisplayArea();

                // Test with invalid radius
                Shape invalidShape = new Circles(-5); // This will throw an exception
                invalidShape.DisplayArea();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Invalid operation: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Demonstrates various overloads of the Array.Sort method.
    /// </summary>
    public class ArraySort
    {
        public static void SortMethod11()
        {
            string[] names = { "Sameera", "Anu", "Logesh", "Ganesh", "Vijay" };
            Array.Sort(names, (x, y) => string.Compare(x, y)); // Custom comparison logic sort in  ascending order
            Console.WriteLine("\nSorted Names - letter ascending:");
            Console.WriteLine(string.Join(", ",names)); 

        }
        public static void SortMethod12()
        {
            int[] numbers = { 3, 1, 4, 5, 2, 9, 6 };
            Array.Sort(numbers, 2, 4); // Sorts elements from index 2 to 5 inclusive
            Console.WriteLine("\nPartially Sorted Numbers (Range 2-5):");
            Console.WriteLine(string.Join(", ", numbers)); 

        }
        public static void SortMethod13()
        {
            string[] words = { "banana", "apple", "cherry", "date", "elderberry" };
            Array.Sort(words, 1, 3, Comparer<string>.Create((x, y) => y.CompareTo(x))); // Sorts elements from index 1 to 3 base on letter descending
            Console.WriteLine("\nPartially Sorted Words (Range 1-3 letter descending):");
            Console.WriteLine(string.Join(", ", words)); 

        }
        public static void SortMethod14()
        {
            string[] keys = { "banana", "apple", "cherry", "date", "elderberry" };
            int[] values = { 5, 3, 7, 4, 6 };
            Array.Sort(keys, values, 1, 3, Comparer<string>.Create((x, y) => x.Length.CompareTo(y.Length))); // Sort both arrays based on the length of the keys in descending order
            Console.WriteLine("\nSorted Keys and Values (Range 1-3, by key length ascending):");
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"Key: {keys[i]}, Value: {values[i]}");
            }
        }
    }
}
