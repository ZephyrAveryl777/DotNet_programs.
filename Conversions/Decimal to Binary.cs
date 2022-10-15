/*
 * C# Program to Convert Decimal to Binary
 */
using System;
class myclass
{
    static void Main()
    {
        //int num;
        Console.Write("Enter a Number : ");
        int num = int.Parse(Console.ReadLine());
        int quot;
        string rem = "";
        while (num >= 1)
        {
            quot = num / 2;
            rem += (num % 2).ToString();
            num = quot;
        }
        string bin = "";
        for (int i = rem.Length - 1; i >= 0; i--)
        {
            bin = bin + rem[i];
        }
        Console.WriteLine("The Binary format for given number is {0}", bin);
        Console.Read();
    }
}
