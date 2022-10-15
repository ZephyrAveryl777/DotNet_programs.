/*
 * C# Program to Perform Decimal to HexaDecimal Conversion
 */
using System;
class program
{
    public static void Main()
    {
        int i = 1, j, temp = 0;
        char[] hexadecimalNumber = new char[100];//hexadecimal contains alphabets
        char temp1;
        Console.WriteLine("Enter a Decimal Number :");
        int decimalNumber = int.Parse(Console.ReadLine());
        int quotient = decimalNumber;
        while (quotient != 0)
        {
            temp = quotient % 16;
            if (temp < 10)
                temp = temp + 48;
            else
                temp = temp + 55;
            temp1 = Convert.ToChar(temp);
            hexadecimalNumber[i++] = temp1;
            quotient = quotient / 16;
        }
        Console.Write("Equivalent HexaDecimal Number is ");
        for (j = i - 1; j > 0; j--)
            Console.Write(hexadecimalNumber[j]);
        Console.Read();
 
    }
}
