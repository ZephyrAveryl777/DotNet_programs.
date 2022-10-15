/*
 * C# Program to Generate the Sum of N Numbers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int  sum = 0;
            Console.Write("Enter the Nth Number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("\nSum of N Numbers : " + sum);
            Console.ReadLine();
 
        }
    }
}
