using System;

class Sample
{
    //Entry point of Program
    static public void Main()
    {
        double logarithm1 = 0.0;
        double logarithm2 = 0.0;

        //Here we get logarithm of base e for 90. 
        logarithm1 = Math.Log(90);

        //Here we get logarithm of base 10 for 90.
        logarithm2 = Math.Log(90,10);
        
        Console.WriteLine("Logarithm of Base E:  "+logarithm1);
        Console.WriteLine("Logarithm of Base 10: "+logarithm2);
    }
}
