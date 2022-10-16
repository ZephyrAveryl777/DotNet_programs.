/* 
double Math.IEEERemainder(double dividend, double divisor);
It returns the remainder of double values.
*/
using System;
class Sample
{
    //Entry point of Program
    static public void Main()
    {
        double REM = 0;      
        REM = Math.IEEERemainder(21.24, 4.0);
        Console.WriteLine("REMAINDER is: " + REM);
    }
}
