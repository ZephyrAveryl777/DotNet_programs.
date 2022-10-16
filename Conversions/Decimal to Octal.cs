/*
 * C# Program to Convert Decimal to Octal
 */
using System;
class program
{
    public static void Main()
    {
        int i = 1;
        int[] octalNumber = new int[100];
        Console.WriteLine("Enter a Decimal Number :");
        int decimalNumber = int.Parse(Console.ReadLine());
        int quotient = decimalNumber;
        while (quotient != 0)
        {
            octalNumber[i++] = quotient % 8;
            quotient = quotient / 8;
        }
        Console.Write("Equivalent Octal Number is ");
        for (int j = i - 1; j > 0; j--)
            Console.Write(octalNumber[j]);
        Console.Read();
    }
}
