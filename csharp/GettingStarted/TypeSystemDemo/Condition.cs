/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
 
  http://www.apache.org/licenses/LICENSE-2.0
 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/

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
