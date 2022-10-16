/*
 * C# Program to Calculate Compound Interest
 */
using System;
namespace compund
{
    class compound
    {
        static void Main(string[] args)
        {
            double Total = 0, interestRate, years, annualCompound, Amount;
            Console.Write("Enter the Initial Amount : ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate of Interest : ");
            interestRate = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Enter the Number of Years : ");
            years = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of Times the Interest will be Compounded : ");
            annualCompound = Convert.ToDouble(Console.ReadLine());
            for (int t = 1; t < years + 1; t++)
            {
                Total = Amount * Math.Pow((1 + interestRate / annualCompound), // A = P(1+(r/100)^n)
                                         (annualCompound * t));
                Console.Write("Your Total for Year {0} "
                            + "is {1:F0}. \n", t, Total);
 
            }
 
            Console.ReadLine();
        }
    }
}
