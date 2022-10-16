using System;

class Sample
{
    //Entry point of Program
    static public void Main()
    {
        decimal decNum = 123.4567m;
        double dblNum = 123.4567;

        Console.WriteLine("Demonstration of Truncate method: ");
        Console.WriteLine(Math.Truncate(decNum));
        Console.WriteLine(Math.Truncate(dblNum));
    
    }
}
