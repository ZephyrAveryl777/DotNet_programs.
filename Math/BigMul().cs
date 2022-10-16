/*
long Math.BigMul(int Val1, int Val2);
It returns a long integer value.
*/
using System;

class Sample
{
    //Entry point of Program
    static public void Main()
    {
        int IntVal1 = 0;
        int IntVal2 = 0;
        long BigMultResult=0;
        long SimpleMultResult = 0;

        IntVal1 = Int32.MaxValue;
        IntVal2 = Int32.MaxValue;

        SimpleMultResult = IntVal1 * IntVal1;
        BigMultResult = Math.BigMul(IntVal1, IntVal2);

        Console.WriteLine("Result of Simple product of MaxValues: " + SimpleMultResult);  
        Console.WriteLine("Result of product of MaxValues using BigMul(): " + BigMultResult);  
    }
}
