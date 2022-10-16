/*
 * C# Program to Find and Display the L.C.M of a Given Number 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication9
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, x, y, lcm = 0;
            Console.Write("Enter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            x = num1;
            y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            lcm = (x * y) / num1;
            Console.Write("Least Common Multiple is : " + lcm);
            Console.Read();
        }
    }
}
