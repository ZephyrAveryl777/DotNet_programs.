/*
 * C# Program to Display All the Prime Numbers in range
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            Console.Write("Enter lower range");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upper range");
            int upper = Convert.ToInt32(Console.ReadLine());
            for (int i = lower; i <= upper; i++)
            {
                for (int j = lower; j <= upper; j++)
                {
 
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
 
                }
                if (isPrime)
                {
                    Console.Write("\t" +i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
