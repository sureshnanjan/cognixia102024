using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public class VotingEligibility
    {
        // Method using If-Else condition to check voting eligibility
        public void CheckIfElse(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote.");
            }
            else
            {
                Console.WriteLine("Not eligible to vote.");
            }
        }

        // Method using Switch-Case condition to categorize age groups
        public void CheckAgeCategory(int age)
        {
            switch (age)
            {
                case < 13:
                    Console.WriteLine("Child");
                    break;
                case >= 13 and < 18:
                    Console.WriteLine("Teenager");
                    break;
                case >= 18 and < 65:
                    Console.WriteLine("Adult");
                    break;
                case >= 65:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("Invalid age");
                    break;
            }
        }

        // Method using Ternary condition to determine voting eligibility
        public void CheckTernary(int age)
        {
            string eligibility = (age >= 18) ? "Eligible to vote" : "Not eligible to vote";
            Console.WriteLine(eligibility);
        }
    }
    }
