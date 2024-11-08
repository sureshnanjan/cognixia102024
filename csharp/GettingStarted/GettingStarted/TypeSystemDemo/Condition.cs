using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    using System;

    namespace GettingStarted
    {
        public class Condition
        {
            // Method for If-Else condition
            public void CheckIfElse()
            {
                int number = 10;

                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else
                {
                    Console.WriteLine("The number is not positive.");
                }
            }

            // Method for Switch-Case condition
            public void CheckSwitchCase()
            {
                int dayOfWeek = 3; // 1 = Sunday, 2 = Monday, ..., 7 = Saturday

                switch (dayOfWeek)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid day");
                        break;
                }
            }

            // Method for Ternary condition
            public void CheckTernary()
            {
                int number1 = 5;
                string result = (number1 > 0) ? "Positive" : "Non-positive";
                Console.WriteLine(result);
            }
        }
    }

}
