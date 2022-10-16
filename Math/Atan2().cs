using System;

class Sample
{
    //Entry point of Program
    static public void Main()
    {
        double X    = 0.5;
        double Y    = 0.6;
        double Tan  = 0.0;

        Tan = Math.Atan2(Y,X);
        
        System.Console.WriteLine("Result is: "+Tan);
    }
}
