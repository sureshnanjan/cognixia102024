using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace Assignment
{

    //Referring to the 2 Method Declarations found below, call both these methods and
    //justify that the correct pass by value and pass by reference is happening.
    public class Assignment8
    {
        static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
            Console.WriteLine($"Inside squareVal: {valParameter}"); // Square of the value inside method
        }

        // Pass by Reference: The parameter refers to the original argument.
        static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;
            Console.WriteLine($"Inside squareRef: {refParameter}"); // Square of the value inside method
        }

        public void Output1()
        {
            int number = 5;

            // Calling the method that uses pass-by-value
            Console.WriteLine($"Before squareVal: {number}");
            squareVal(number); // value is passed, the original variable remains unchanged
            Console.WriteLine($"After squareVal: {number}");

            // Calling the method that uses pass-by-reference
            Console.WriteLine($"\nBefore squareRef: {number}");
            squareRef(ref number); // reference is passed, the original variable is modified
            Console.WriteLine($"After squareRef: {number}");
        }


        //Declare a few methods with out , in and make the correct way to call them from a Main program to illustrate the behaviour.
        static void RefMethod(ref int x)
        {
            x = x * 2; // Modify the value of x
            Console.WriteLine($"Inside RefMethod: {x}");
        }

        // Pass by Out (does not require initialization before passing)
        static void OutMethod(out int x)
        {
            x = 10; // Must assign a value to the out parameter
            Console.WriteLine($"Inside OutMethod: {x}");
        }

        // Pass by In (can only read, cannot modify)
        static void InMethod(in int x)
        {
            // x = x * 2; // This would cause a compile-time error because 'x' is readonly
            Console.WriteLine($"Inside InMethod: {x}");
        }

        public void Output2()
        {
            int refVar = 5;

            // Calling the RefMethod
            Console.WriteLine($"Before RefMethod: {refVar}");
            RefMethod(ref refVar);  // ref requires initialization
            Console.WriteLine($"After RefMethod: {refVar}");

            int outVar;
            // Calling the OutMethod
            OutMethod(out outVar);  // out does not require initialization
            Console.WriteLine($"After OutMethod: {outVar}");

            int inVar = 10;
            // Calling the InMethod
            InMethod(inVar);  // in allows read-only reference
            Console.WriteLine($"After InMethod: {inVar}");
        }
    }
}
