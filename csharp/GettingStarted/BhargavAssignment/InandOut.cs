using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhargavAssignment
{
    internal class InandOut
    {
        // Method with 'in' parameter: Only reading the value
        static void printValue(in int value)
        {
            Console.WriteLine($"The value passed using 'in' is: {value}");
        }

        // Method with 'out' parameter: Modifies the value
        static void calculateSquare(out int result, int number)
        {
            result = number * number;  // Calculate square and assign it to the out parameter
        }

        static void Main(string[] args)
        {
            // Demonstrating 'in' parameter
            int valueIn = 10;
            Console.WriteLine("Calling method with 'in' parameter...");
            printValue(in valueIn);  // 'in' allows passing the value as read-only reference

            // Demonstrating 'out' parameter
            int resultOut;
            int number = 5;
            Console.WriteLine("\nCalling method with 'out' parameter...");
            calculateSquare(out resultOut, number);  // 'out' expects the variable to be assigned in the method
            Console.WriteLine($"The square of {number} is: {resultOut}");
        }
    }
}
