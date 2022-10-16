using System;
using System.IO;

class Sample
{
    //Entry point of Program
    static public void Main()
    {
        double[] doubles = { Double.MaxValue,Double.MinValue, 157.37, 120.00, -5.96 };
        decimal[] decimals = { Decimal.MaxValue,Decimal.MinValue, 157.37M, 120.00M, -5.96M };

        int[] integers = { Int32.MaxValue,Int32.MinValue, 157, 120, -5 };

        Console.WriteLine("Double Values:");
        foreach (double VAL in doubles)
            Console.WriteLine("\tMath.Abs({0}) : {1}", VAL, Math.Abs(VAL));

        Console.WriteLine("\nDecimal Values:");
        foreach (decimal VAL in decimals)
            Console.WriteLine("\tMath.Abs({0}) : {1}", VAL, Math.Abs(VAL));

        Console.WriteLine("\nInteger Values:");
        foreach (decimal VAL in integers)
            Console.WriteLine("\tMath.Abs({0}) : {1}", VAL, Math.Abs(VAL));   
    }
}
