using System;  
                      
public class HappyNumbers  
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
        //Displays all happy numbers in range  
        Console.WriteLine("List of happy numbers in range : ");  
        Console.Write("Enter lower limit: ")
        int lower = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter upper limit: ");
        int upper = Convert.ToInt32(Console.ReadLine());
        for(int i = lower; i <= upper; i++){  
            int result = i;  
              
            //Happy number always ends with 1 and   
            //unhappy number ends in a cycle of repeating numbers which contains 4  
            while(result != 1 && result != 4){  
                result = isHappyNumber(result);  
            }  
              
            if(result == 1)  
                Console.Write(i + " ");  
        }  
    }  
}  
