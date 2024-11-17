using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyaAssignment
{
    internal class Overload
    {
        static void Main(string[] args)
        {
            // Calling the addNumbers method with different argument types
            Console.WriteLine(addNumbers(0, 0));
            Console.WriteLine(addNumbers(1.0f, 1.0f));
            Console.WriteLine(addNumbers(1.0, 1.0));
            Console.WriteLine(addNumbers(1, 1.0f));
            Console.WriteLine(addNumbers(1.0f, 1));
            Console.WriteLine(addNumbers(1.0f, 1.0f, "This is with additional inputs"));
        }

        // Overload for two integer inputs
        public static int addNumbers(int input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload for two float inputs
        public static float addNumbers(float input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload for two double inputs
        public static double addNumbers(double input1, double input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload for an integer and a float input
        public static float addNumbers(int input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload for a float and an integer input
        public static float addNumbers(float input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return input1 + input2;
        }

        // Overload for two float inputs and a string message
        public static string addNumbers(float input1, float input2, string additionalInput)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            return $"{input1 + input2} - {additionalInput}";
        }
    }
}