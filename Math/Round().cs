using System;
class Sample
{
    //Entry point of Program
    static public void Main()
    {
        double val = 0.0;
        decimal decVal = 0.0M;

        Console.WriteLine("Demonstration of Round Method: ");
        val = Math.Round(2.4);
        Console.WriteLine("Value : "+val);

        val = Math.Round(2.5);
        Console.WriteLine("Value : " + val);

        val = Math.Round(2.6);
        Console.WriteLine("Value : " + val);

        val = Math.Round(2.4567,2);
        Console.WriteLine("Value : " + val);

        val = Math.Round(2.4567, 3);
        Console.WriteLine("Value : " + val);

        decVal = Math.Round(2.4567M, 2);
        Console.WriteLine("Decimal Value : " + decVal);

        decVal = Math.Round(2.4567M,MidpointRounding.AwayFromZero);
        Console.WriteLine("Decimal Value : " + decVal);
    }
}
