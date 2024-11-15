using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class Program
    {
        // Method for pass by value
        public static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
            Console.WriteLine($"Inside squareVal: {valParameter}");
        }

        // Method for pass by reference
        public static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;
            Console.WriteLine($"Inside squareRef: {refParameter}");
        }

        // Method demonstrating the 'out' keyword
        public static void MultiplyOut(int x, int y, out int result)
        {
            result = x * y;
        }

        // Method demonstrating the 'in' keyword
        public static void DisplaySquare(in int value)
        {
            Console.WriteLine($"Square of {value}: {value * value}");
        }
    }
}
