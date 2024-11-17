using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyaAssignment
{
    internal class Invocation
    {
        static void Main(string[] args)
        {
            // No arguments
            SimpleMethod();

            // Positional arguments followed by a sequence of remaining arguments
            SimpleMethod(10, "Hello", false, "arg1", "arg2", "arg3");

            // Calling by named parameter convention
            SimpleMethod(str: "Changed in Call", option: false);
        }

        static void SimpleMethod(int number = 555, string str = "DEFAULT", bool option = true, params string[] remaining)
        {
            // Modifying local variables
            number = 100;
            str = "Changed in Method";

            // Outputting the details
            Console.WriteLine($"Str in Method: {str} - Number in Method: {number} - The Bool Value is {option}");
            Console.WriteLine($"The all trailing params got here is {remaining.Length}");
        }
    }
}