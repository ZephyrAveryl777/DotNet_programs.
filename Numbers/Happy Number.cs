/* Happy Number:
happy number can be defined as a number which will yield 1 when it is replaced by the sum of the square of its digits repeatedly
32 + 22 = 13
12 + 32 = 10
12 + 02 = 1
examples of happy numbers are 7, 28, 100, 320 and so on.
*/

using System;  
                      
public class HappyNumber  
{  
    //isHappyNumber() will determine whether a number is happy or not  
    public static int isHappyNumber(int num){  
        int rem = 0, sum = 0;  
          
        //Calculates the sum of squares of digits  
        while(num > 0){  
            rem = num%10;  
            sum = sum + (rem*rem);  
            num = num/10;  
        }  
        return sum;  
    }  
      
    public static void Main()  
    {  
      Console.Write("Enter number");
        int num = Convert.ToInt32(Console.ReadLine());  
        int result = num;  
          
        while(result != 1 && result != 4){  
            result = isHappyNumber(result);  
        }  
          
        //Happy number always ends with 1  
        if(result == 1)  
            Console.WriteLine(num + " is a happy number");  
        //Unhappy number ends in a cycle of repeating numbers which contains 4  
        else if(result == 4)  
            Console.WriteLine(num + " is not a happy number");    
    }  
}  
