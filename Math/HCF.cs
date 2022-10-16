/*
 * C# Program to Find and Display the H.C.F of a Given Number 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1,num2,i;
            int hcf =0;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            for(i=1;i<=num1||i<=num2;++i)
            {
                if(num1%i==0 && num2%i==0)
                {
                    hcf=i;
                }
            }    
            Console.Write("\nCommon Factor is : ");
            Console.WriteLine(hcf);
            Console.Read();
         }
    }
}
