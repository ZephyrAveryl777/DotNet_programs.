/*
Abundant Number: abundant number can be called as an excessive number and defined as the number for which the sum of its proper divisors is greater than the number itself.
Ex: 12 => proper divisors(1,2,3,4,5,6) => sum(16) > number(12).
other examples: 12,18,20,24,30,36.
*/
using System;   
public class AbundantNumber {   
public static int getSum(int n)   
    {   
        int sum = 0;     
        for (int i = 1; i <= (Math.Sqrt(n)); i++) {   
            if (n % i == 0) {    
                if (n / i == i)   
                    sum = sum + i;   
                else   
                {   
                    sum = sum + i;   
                    sum = sum + (n / i);   
                }   
            }   
        }   
        sum = sum - n;   
        return sum;   
    }   
    static bool Abundant(int n)   
    {   
        return (getSum(n) > n);   
    }   
    
    public static void Main()   
    {   
        Console.WriteLine("Enter the number?");  
        int n = Convert.ToInt32(Console.ReadLine());  
        if(Abundant(n))  
        {  
            Console.WriteLine("The number is Abundant.");  
        }  
        else  
        {  
            Console.WriteLine("The number is not Abundant.");  
        }  
    }   
}  
