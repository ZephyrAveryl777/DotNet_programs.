/* 
Hazard number: A number is said to be the Harshad number if it is divisible by the sum of its digit.
Let 156 => sum of digits -> 1+5+6 = 12; 156 is also divisible by 12 => 156 is a hazard number. 
examples of Harshad number are 8, 54, 120,etc.
*/
using System;  
                      
public class HarshadNumber  
{  
    public static void Main()  
    {  
        int num = 156;  
        int rem = 0, sum = 0, n;  
          
        //Make a copy of num and store it in variable n  
        n = num;  
          
        //Calculates sum of digits  
        while(num > 0){  
            rem = num%10;  
            sum = sum + rem;  
            num = num/10;  
        }  
          
        //Checks whether number is divisible by sum of digits  
        if(n%sum == 0)  
            Console.WriteLine(n + " is a harshad number");  
        else  
            Console.WriteLine(n + " is not a harshad number");  
    }  
}  
