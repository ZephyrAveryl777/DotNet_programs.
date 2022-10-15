/* 
Deficient Number: deficient number can be defined as the number for which the sum of the proper divisors is lesser than the number itself.
Ex: 12 => Factors are 1,3,7, it has sum(11), lesser than it self.
*/
using System;   
class Deficient{    
   static int divsum(int n)   
    {   
      int sum = 0;   
    
      for (int i = 1; i <= (Math.Sqrt(n)); i++) {   
           if (n % i == 0) {  
               if (n / i == i) {   
                   sum = sum + i;   
                }   
               else               {   
                   sum = sum + i;   
                   sum = sum + (n / i);   
                }   
            }   
        }   
    
       return sum;   
    }   
    
 static bool isDef(int n)   
    {   
     return (divsum(n) < (2 * n));   
    }   
    
 public static void Main()   
    {   
      Console.WriteLine("Enter a number: ");  
      int n = Convert.ToInt32(Console.ReadLine());  
      if(isDef(n))  
      {  
          Console.WriteLine("The number is deficient.");  
      }  
      else  
      {  
          Console.WriteLine("The number is not deficient.");  
      }  
}   
}   
