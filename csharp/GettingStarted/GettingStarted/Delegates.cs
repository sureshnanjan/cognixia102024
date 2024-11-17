using System;

class Program
{
    // Method matching delegate 1: takes 2 ints and 2 floats, returns a bool
    public static bool CompareSum(int int1, int int2, float float1, float float2)
    {
        return (int1 + int2) > (float1 + float2);
    }

    // Method matching delegate 2: takes an int and a float, returns a string
    public static string SumAsString(int i, float f)
    {
        return $"The result is: {i + f}";
    }
}

