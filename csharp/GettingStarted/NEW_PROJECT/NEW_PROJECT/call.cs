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

