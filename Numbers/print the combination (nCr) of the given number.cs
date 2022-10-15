/*
Combination (nCr) can be defined as the combination of n things taken r at a time without any repetition.
nCr = [n(n-1) ... (n-r+1)] / r(r-1)...1  
*/

using System;   
class Combination  
{  
static int nCr(int n, int r)   
{   
   return fact(n) / (fact(r) *   
     fact(n - r));   
}   
  static int fact(int n)   
{   
  int res = 1;   
  for (int i = 2; i <= n; i++)   
   res = res * i;   
  return res;   
}   
   public static void Main()   
 {     
   Console.WriteLine("Enter the value of n and r?");  
   int n = Convert.ToInt32(Console.ReadLine());  
   int r = Convert.ToInt32(Console.ReadLine());  
   Console.Write("nCr = "+nCr(n, r));   
 }   
}   
