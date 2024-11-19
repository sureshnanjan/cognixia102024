using System.Runtime.CompilerServices;
using System;
namespace My_CSharp
{
    
        /// <summary>
        /// The <see cref="CodingConventions"/> class serves as the entry point for the application and demonstrates basic coding conventions and documentation.
        /// </summary>
        public class Conventions
        {
       
            /// <summary>
            /// The main entry point for the application.
            /// It demonstrates the use of a simple calculator class and how documentation is applied to code.
            /// </summary>
            /// <param name="args">An array of command-line arguments passed to the application.</param>

        }

        /// <summary>
        /// Represents a simple calculator with basic arithmetic operations such as addition, subtraction, multiplication, and division.
        /// </summary>
        public class EnhancedCalculator
        {
            /// <summary>
            /// Adds two integers.
            /// </summary>
            /// <param name="a">The first integer to add.</param>
            /// <param name="b">The second integer to add.</param>
            /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
            public int Add(int a, int b)
            {
                return a + b;
            }
        

            /// <summary>
            /// Subtracts one integer from another.
            /// </summary>
            /// <param name="a">The integer to subtract from.</param>
            /// <param name="b">The integer to subtract.</param>
            /// <returns>The result of subtracting <paramref name="b"/> from <paramref name="a"/>.</returns>
            public int Subtract(int a, int b)
            {
                return a - b;
            }

            /// <summary>
            /// Multiplies two integers.
            /// </summary>
            /// <param name="a">The first integer to multiply.</param>
            /// <param name="b">The second integer to multiply.</param>
            /// <returns>The product of <paramref name="a"/> and <paramref name="b"/>.</returns>
            public int Multiply(int a, int b)
            {
                return a * b;
            }

            /// <summary>
            /// Divides one integer by another.
            /// </summary>
            /// <param name="a">The numerator (dividend).</param>
            /// <param name="b">The denominator (divisor).</param>
            /// <returns>The quotient of <paramref name="a"/> divided by <paramref name="b"/>.</returns>
            /// <exception cref="DivideByZeroException">Thrown when <paramref name="b"/> is zero.</exception>
            public double Divide(int a, int b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return (double)a / b;
            }
        
        }
    }

