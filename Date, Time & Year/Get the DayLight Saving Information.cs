/*
 * C# Program to Get the DayLight Saving Information
 */
using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        TimeZone z = TimeZone.CurrentTimeZone;
        DaylightTime t = z.GetDaylightChanges(DateTime.Today.Year);
        Console.WriteLine("Start Time: {0}", t.Start);
        Console.WriteLine("Delta Time: {0}", t.Delta);
        Console.WriteLine("End Time: {0}", t.End);
        Console.ReadLine();
    }
}
