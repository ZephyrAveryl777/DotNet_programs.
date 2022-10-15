/*
 * C# Program to Add Two Dates 
 */
using System;
namespace DateAndTime
{
    class Program
    {
        static int Main()
        {
            DateTime SDate = new DateTime(2010, 10, 7);
            Console.WriteLine("Starting Date : {0}", SDate);
            DateTime EDate = startDate.AddDays(10);
            Console.WriteLine("Ending Date   : {0}\n", EDate);
            Console.ReadLine();
            return 0;
        }
    }
}
