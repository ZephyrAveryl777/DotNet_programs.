/*
 * C# Program to Covert HexaDecimal Number to Decimal
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           string Input;
           Console.WriteLine("Enter a Hexadecimal Number :");
           Input = Console.ReadLine();
           int Output = int.Parse(Input, System.Globalization.NumberStyles.HexNumber);
           Console.WriteLine("The Decimal value is " + Output);
           Console.Read();
        }
    }
}
