/*
ordered-arrangement/combination of a set of things or collection of objects.
n!= n (n-1)(n-2)(n-3)....3.2.1  
nPr = n!/ (n-r)! =n(n-1) (n-2)(n-3).....(n-r+1) 
*/
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace Permutation  
{  
    public class Program  
    {  
        public static void Main(string[] args)  
        {  
            int n, r, per, fact1, fact2;  
            Console.WriteLine("Enter the Value of n and r?");  
            n = Convert.ToInt32(Console.ReadLine());  
            r = Convert.ToInt32(Console.ReadLine());  
            fact1 = n;  
            for (int i = n - 1; i >= 1; i--)  
            {  
                fact1 = fact1 * i;  
            }  
            int number;  
            number = n - r;  
            fact2 = number;  
            for (int i = number - 1; i >= 1; i--)  
            {  
                fact2 = fact2 * i;  
            }  
            per = fact1 / fact2;  
            Console.WriteLine("nPr = "+per);  
            Console.ReadLine();  
        }  
    }  
}  
