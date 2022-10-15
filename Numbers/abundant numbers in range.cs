using System;   
public class Abundant {   
    public static void Main()   
    {   
int i ,j;  
Console.Write("Enter a range: ");
int n = Convert.ToInt32(Console.ReadLine());
int su = 0;  
for(i = 1;i<=n;i++)  
{  
  for(j=1; j<=i/2;j++)  
    {  
      if (i % j == 0){  
            su = su + j;  
            }  
    }  
  if (su > i)  
    {  
        Console.Write(i+" ");  
    }  
    su = 0;  
    }  
}  
}  
