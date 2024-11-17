using System;
public class CallByRef
{
    public static void squareIn(in int inParameter)
    {
        // inParameter *= inParameter;  // Error: cannot modify an 'in' parameter
        Console.WriteLine($"inParameter is {inParameter} (can't be modified).");
    }

    // Method using 'out' (parameter must be assigned a value inside the method)
    public static void squareOut(out int outParameter)
    {
        outParameter = 10;  // Must assign a value
        outParameter *= outParameter;
    }

    // Method using 'ref' (parameter must be initialized before passing and can be modified)
    public static void squareRef(ref int refParameter)
    {
        refParameter *= refParameter;
    }
}
