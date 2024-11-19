using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_CSharp
{
    public class MethodCalling
    {
        public static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
            Console.WriteLine("Inside squareVal: " + valParameter);
        }

        // Method using pass-by-reference
        public static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;
            Console.WriteLine("Inside squareRef: " + refParameter);
        }
        public static void ModifyWithRef(ref int value)
        {
            value *= 2;
            Console.WriteLine("Inside ModifyWithRef: " + value);
        }
        public static void InitializeWithOut(out int value)
        {
            value = 100;
            Console.WriteLine("Inside InitializeWithOut: " + value);
        }
        public static void ReadOnlyWithIn(in int value)
        {

            Console.WriteLine("Inside ReadOnlyWithIn: " + value);
        }

    }
}
