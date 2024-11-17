using System;
public class CallByValue
{
    public static void squareVal(int valParameter)
    {
        valParameter *= valParameter; // This modifies the local copy, not the original
    }

    // Pass-by-reference method
    public static void squareRef(ref int refParameter)
    {
        refParameter *= refParameter; // This modifies the original value since ref is used
    }


}

