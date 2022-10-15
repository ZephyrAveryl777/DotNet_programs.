/*
Prime Number:  A number which is a prime number and reverse of this number is also a prime number.
Ex:  2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79
*/
using System;   
public class PrimeNumber  
{  
   public static void Main()  
    {  
      
        int reverse,sum=0,flag;  
       Console.Write("Enter a prime number: ");  
       int n = Convert.ToInt32(Console.ReadLine());  
         
while(n!=0)  
    {  
        reverse = n%10;  
        sum = sum*10 + reverse;  
        n= n/10;  
    }   
    flag = 0;  
    for (int j = 2; j <= sum / 2; j++)  
    {  
        if ((sum % j) == 0)  
        {  
            flag = 1;  
            break;  
        }  
    }  
    if (flag == 0)  
            Console.WriteLine("Twisted Prime");  
     else  
            Console.WriteLine("Not Twisted Prime");  
  }
}  
