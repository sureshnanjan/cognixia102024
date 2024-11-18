using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Csharp
{
    public class MethodCallingConventions
    {
        // Method with pass by value
        static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
            Console.WriteLine("Inside squareVal: " + valParameter);  // Displays the squared value inside the method
        }

        // Method with pass by reference
        static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;
            Console.WriteLine("Inside squareRef: " + refParameter);  // Displays the squared value inside the method
        }

        // Method with 'in' parameter
        static void displayIn(in int valIn)
        {
            Console.WriteLine("In value: " + valIn);  // Can only read, not modify the value
        }

        // Method with 'out' parameter (output reference, must be assigned inside the method)
        static void calculateOut(int x, out int result)
        {
            result = x * x;  // The value must be assigned inside the method
            Console.WriteLine("Out value: " + result);
        }

        // Method with 'ref' parameter (can be modified inside the method)
        static void squareRefe(ref int valRef)
        {
            valRef *= valRef;  // The value can be modified
            Console.WriteLine("Ref value: " + valRef);
        }

        public static void MethodCall()
        {
            int numVal = 5;
            Console.WriteLine("Before squareVal (pass by value): " + numVal);
            squareVal(numVal);  // Pass by value
            Console.WriteLine("After squareVal: " + numVal);  // The original variable is not affected

            int numRef = 5;
            Console.WriteLine("Before squareRef (pass by reference): " + numRef);
            squareRef(ref numRef);  // Pass by reference
            Console.WriteLine("After squareRef: " + numRef);  // The original variable is affected

            // Demonstrating the 'in' keyword
            int inVal = 10;
            Console.WriteLine("Before displayIn: " + inVal);
            displayIn(in inVal);  // Pass by reference, read-only
            Console.WriteLine("After displayIn: " + inVal);  // The original value remains unchanged

            // Demonstrating the 'out' keyword
            int outVal;
            calculateOut(5, out outVal);  // Must assign value inside the method
            Console.WriteLine("After calculateOut: " + outVal);  // The result is assigned in the method

            // Demonstrating the 'ref' keyword
            int refVal = 3;
            Console.WriteLine("Before squareRef: " + refVal);
            squareRefe(ref refVal);  // Pass by reference, value can be modified
            Console.WriteLine("After squareRef: " + refVal);  // The original value is modified
        }
    }
}
