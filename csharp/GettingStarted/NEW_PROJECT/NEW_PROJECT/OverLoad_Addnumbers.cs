using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJECT
{
    public class OverLoad_Addnumbers
    {
        public void show()
        {
            // Calling all the overloaded methods
            addNumbers(0, 0); // Integer addition
            addNumbers(1.0f, 1.0f); // Float addition
            addNumbers(1.0, 1.0); // Double addition
            addNumbers(1, 1.0f); // Integer and Float addition
            addNumbers(1.0f, 1); // Float and Integer addition
            addNumbers(1.0f, 1.0f, "This is with additional inputs"); // Float addition with a string
        }

        // Overloaded method for int + int
        public static int addNumbers(int input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            int output = input1 + input2;
            Console.WriteLine($"Result: {output}");
            return output;
        }

        // Overloaded method for float + float
        public static float addNumbers(float input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            float output = input1 + input2;
            Console.WriteLine($"Result: {output}");
            return output;
        }

        // Overloaded method for double + double
        public static double addNumbers(double input1, double input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            double output = input1 + input2;
            Console.WriteLine($"Result: {output}");
            return output;
        }

        // Overloaded method for int + float
        public static float addNumbers(int input1, float input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            float output = input1 + input2;
            Console.WriteLine($"Result: {output}");
            return output;
        }

        // Overloaded method for float + int
        public static float addNumbers(float input1, int input2)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            float output = input1 + input2;
            Console.WriteLine($"Result: {output}");
            return output;
        }

        // Overloaded method for float + float with additional string input
        public static float addNumbers(float input1, float input2, string additionalInfo)
        {
            Console.WriteLine($"Add Numbers called with {input1.GetType()} and {input2.GetType()}");
            Console.WriteLine($"Additional Info: {additionalInfo}");
            float output = input1 + input2;
            Console.WriteLine($"Result: {output}");
            return output;
        }
    }
}
