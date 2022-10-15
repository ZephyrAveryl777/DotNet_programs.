/*
 * C# Program to Perform Binary to Decimal Conversion
 */
using System;
using System.Collections.Generic;
using System.Text;
 
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimal_val = 0, base_val = 1, rem;
            Console.Write("Enter a Binary Number(1s and 0s) : ");
            int num = int.Parse(Console.ReadLine()); /* maximum five digits */
            int binary_val = num;
            while (num > 0)
            {
                rem = num % 10;
                decimal_val = decimal_val + rem * base_val;
                num = num / 10 ;
                base_val = base_val * 2;
            }
            Console.Write("The Binary Number is : "+binary_val);
            Console.Write("\nIts Decimal Equivalent is : "+decimal_val);
            Console.ReadLine();
        }
    }
}
