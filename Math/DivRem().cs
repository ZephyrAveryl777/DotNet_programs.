using System;

class Sample
{
    //Entry point of Program
    static public void Main()
    {
        int REM = 0;
        int QUOTIENT = 0;

        QUOTIENT = Math.DivRem(21, 4, out REM);

        Console.WriteLine("QUOTIENT is: " + QUOTIENT);
        Console.WriteLine("REMAINDER is:" + REM);
    }
}
