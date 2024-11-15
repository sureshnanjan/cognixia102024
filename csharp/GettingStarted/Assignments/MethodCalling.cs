using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class MethodCalling
    {
        static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
            Console.WriteLine($"Inside squareVal (Pass-by-Value): {valParameter}");
        }

        // Pass-by-reference method
        static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;
            Console.WriteLine($"Inside squareRef (Pass-by-Reference): {refParameter}");
        }

        // Method with 'out' parameter
        static void GetValues(out int number, out string message)
        {
            number = 42; // Must initialize 'out' parameters
            message = "Hello from GetValues!";
        }

        // Method with 'in' parameter
        static void ShowValue(in int readOnlyValue)
        {
            // readOnlyValue = 10; // This will cause a compile-time error because 'in' parameters are read-only
            Console.WriteLine($"Inside ShowValue (Pass-by-ReadOnly): {readOnlyValue}");
        }
        public static void execute()
        {
            // Pass-by-value example
            int value = 5;
            Console.WriteLine($"Before squareVal: {value}");
            squareVal(value);
            Console.WriteLine($"After squareVal: {value}");

            // Pass-by-reference example
            int reference = 5;
            Console.WriteLine($"\nBefore squareRef: {reference}");
            squareRef(ref reference);
            Console.WriteLine($"After squareRef: {reference}");

            // Out parameters example
            Console.WriteLine("\n=== Out Parameters Example ===");
            GetValues(out int number, out string message);
            Console.WriteLine($"Number: {number}, Message: {message}");

            // In parameter example
            Console.WriteLine("\n=== In Parameters Example ===");
            int readOnlyValue = 100;
            ShowValue(in readOnlyValue);

            // Combining all
            Console.WriteLine("\n=== Summary ===");
            Console.WriteLine($"Final Value: {value}, Final Reference: {reference}, ReadOnlyValue: {readOnlyValue}");
        }
    }
}
