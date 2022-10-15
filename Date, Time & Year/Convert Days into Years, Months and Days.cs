/*
 * C# Program to Convert a Given Number of Days in terms of 
 * Years, Weeks & Days
 */
using System;
class program
{
    public static void Main()
    {
        int ndays, year, week, days, DAYSINWEEK=7;
        Console.WriteLine("Enter the number of days");
        ndays = int.Parse(Console.ReadLine());
        year = ndays / 365;
        week = (ndays % 365) / DAYSINWEEK;
        days = (ndays % 365) % DAYSINWEEK;
        Console.WriteLine("{0} is equivalent to {1}years, {2}weeks and {3}days", 
                           ndays, year, week, days);
        Console.ReadLine();
    }
}
