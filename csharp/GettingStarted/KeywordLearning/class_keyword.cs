using System;
using System.Threading.Tasks;

namespace KeywordLearning
{
    // Demonstrating use of abstract class and sealed class
    public abstract class AbstractClass
    {
        // Abstract method (cannot be implemented here)
        public abstract void AbstractMethod();
    }

    // Sealed class cannot be inherited
    public sealed class SealedClass : AbstractClass
    {
        // Overriding abstract method
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract Method Implemented.");
        }
    }

    public class class_keyword
    {
        // 'const' keyword for constant variables
        const int constantValue = 100;

        // Fields
        private int _privateField; // 'private' access modifier
        public int PublicField { get; set; } // 'public' access modifier, 'get', 'set'

        // Properties using the 'readonly' keyword
        public readonly string ReadOnlyField;

        // Constructor (with the correct name and initialization)
        public class_keyword(int value)
        {
            this._privateField = value;  // 'this' refers to the current instance of the class
            this.ReadOnlyField = "I am read-only";
        }

        // Method demonstrating 'ref', 'out', and 'params' keywords
        public void MethodWithKeywords(ref int refValue, out string outValue, params int[] numbers)
        {
            // 'ref' keyword: Passing by reference
            refValue += 1;

            // 'out' keyword: Must be assigned before use
            outValue = "Output Value Set";

            // Using 'params' keyword: Variable arguments
            foreach (var number in numbers)
            {
                Console.WriteLine($"Param value: {number}");
            }
        }

        // Method demonstrating 'return' and 'void' (no return value)
        public int AddNumbers(int a, int b)
        {
            return a + b;  // 'return' keyword
        }

        // Method demonstrating 'async', 'await' and 'Task'
        public async Task<int> MultiplyNumbersAsync(int a, int b)
        {
            await Task.Delay(1000); // 'await' keyword to delay asynchronously
            return a * b;
        }

        // Switch statement with 'case'
        public void SwitchExample(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        // 'try-catch-finally' block
        public void ExceptionHandlingExample()
        {
            try
            {
                int result = 10 / 1;  // Correct division (previously division by zero)
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }

        // 'if-else' statement
        public void IfElseExample(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive number");
            }
            else
            {
                Console.WriteLine("Non-positive number");
            }
        }

        // 'for' and 'foreach' loops
        public void LoopExamples()
        {
            // 'for' loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For loop iteration: {i}");
            }

            // 'foreach' loop
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (var name in names)
            {
                Console.WriteLine($"Name: {name}");
            }
        }

        // 'is' keyword for type checking
        public void IsExample(object obj)
        {
            if (obj is string)
            {
                Console.WriteLine("It's a string.");
            }
            else
            {
                Console.WriteLine("It's not a string.");
            }
        }

        // 'goto' keyword (rarely used, for demo purposes)
        public void GotoExample()
        {
            int i = 0;
        start:
            if (i < 5)
            {
                Console.WriteLine($"Goto example iteration: {i}");
                i++;
                goto start; // Using 'goto'
            }
        }

        // 'delegate' keyword
        public delegate void MyDelegate(string message);

        // Method using delegate
        public void DelegateExampleMethod(string message)
        {
            Console.WriteLine($"Delegate received message: {message}");
        }

        // Method demonstrating 'lock' keyword
        public void LockExample()
        {
            object lockObject = new object();
            lock (lockObject)
            {
                Console.WriteLine("Critical section accessed with lock.");
            }
        }

        // 'throw' keyword
        public void ThrowExample()
        {
            throw new InvalidOperationException("This is an example of throw.");
        }

        // Using 'this' in method
        public void ThisKeywordExample()
        {
            Console.WriteLine($"The value of this._privateField: {this._privateField}"); // 'this' refers to the instance
        }

        // 'sizeof' and 'typeof' usage
        public void SizeofAndTypeofExample()
        {
            Console.WriteLine($"Size of int: {sizeof(int)} bytes"); // 'sizeof' keyword
            Console.WriteLine($"Type of int: {typeof(int)}"); // 'typeof' keyword
        }
    }

    // Enum to demonstrate the use of 'enum'
    public enum CarType
    {
        Sedan,
        SUV,
        Truck
    }
}
