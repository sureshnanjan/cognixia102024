using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning;

using System;

public class delegatedemo
{
    // Declare a delegate that takes an int and returns an int
    public delegate int OperationDelegate(int num);
}

public class Calculator
{
    // Method to calculate the square of a number
    public int Square(int x)
    {
        return x * x;
    }

    // Method to calculate double of a number
    public int Double(int x)
    {
        return x * 2;
    }

    // Method to calculate the cube of a number
    public int Cube(int x)
    {
        return x * x * x;
    }

    // Method that accepts a delegate to perform a calculation
    public void PerformOperation(delegatedemo.OperationDelegate operation, int num)
    {
        int result = operation(num);
        Console.WriteLine("Result: " + result);
    }
}

class Program
{
   
}
