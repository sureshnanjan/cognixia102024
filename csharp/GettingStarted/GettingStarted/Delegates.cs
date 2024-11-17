﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GettingStarted
{
    public class Delegates
    {
        internal static bool CompareValues(int x, int y, float a, float b)
        {
            return (x + y) > (a + b);
        }


        public static string FormatResult(int num, float value)
        {
            return $"The number is {num} and the value is {value:F2}";
        }
    }
}
