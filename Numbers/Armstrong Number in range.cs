/*
 *  C# Program to Print all the Armstrong Numbers in range
 */
using System;
class Program
{
    static void Main()
    {
        int a, b, c, d;
        Console.Write("Enter lower limit: );
        int lower = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter upper limit: );
        int upper = Convert.ToInt32(Console.ReadLine());
        for (int i = lower; i <= upper; i++)
        {
            a = i / 100;
            b = (i - a * 100) / 10;
            c = (i - a * 100 - b * 10);
            d = a * a * a + b * b * b + c * c * c;
            if (i == d)
            {
                System.Console.WriteLine("{0}", i);
            }
        } 
        Console.Read();
    }
}
