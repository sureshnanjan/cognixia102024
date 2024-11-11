using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
    {
        public delegate int Operation(int a, int b);

        public class Calculator
        {

            public int Add(int a, int b)
            {
                return a + b;
            }


            public int Subtract(int a, int b)
            {
                return a - b;
            }


            public int Multiply(int a, int b)
            {
                return a * b;
            }
        }

    }
 

