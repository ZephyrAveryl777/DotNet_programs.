/*
 * C# Program to get the Universal Time
 */
using System;
class Program
{
    static void Main()
    {
        TimeZone zone = TimeZone.CurrentTimeZone;
        DateTime univ = zone.ToUniversalTime(DateTime.Now);
        Console.WriteLine("Universal Time is {0}",univ);
        Console.Read();
    }
}
