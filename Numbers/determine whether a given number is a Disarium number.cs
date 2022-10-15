/* 
Disarium Number:
A number is said to be the Disarium number when the sum of its digit raised to the power of their respective positions is equal to the number itself.
11 + 72 + 53 = 1 + 49 + 125 = 175
Ex: 89, 135, 518
*/
using System;                      
public class DisariumNumber  
{  
    //calculateLength() will count the digits present in a number  
    public static int calculateLength(int n){  
        int length = 0;  
        while(n != 0){  
            length = length + 1;  
            n = n/10;  
        }  
        return length;  
    }  
      
    public static void Main()  
    {  
        int num = 175, sum = 0, rem = 0, n;  
        int len = calculateLength(num);  
          
        //Makes a copy of the original number num  
        n = num;  
          
        //Calculates the sum of digits powered with their respective position  
        while(num > 0){  
            rem = num%10;  
            sum = sum + (int)Math.Pow(rem,len);  
            num = num/10;  
            len--;  
        }  
          
        //Checks whether the sum is equal to the number itself  
        if(sum == n)  
            Console.WriteLine(n + " is a disarium number");  
        else  
            Console.WriteLine(n + " is not a disarium number");  
    }  
}  
