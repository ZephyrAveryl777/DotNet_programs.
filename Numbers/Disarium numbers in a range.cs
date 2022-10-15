using System;  
                      
public class DisariumNumbers  
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
      
    //sumOfDigits() will calculates the sum of digits powered with their respective position  
    public static int sumOfDigits(int num){  
        int sum = 0, rem = 0;  
        int len = calculateLength(num);  
          
        while(num > 0){  
            rem = num%10;  
            sum = sum + (int)Math.Pow(rem,len);  
            num = num/10;  
            len--;  
        }  
        return sum;  
    }  
      
    public static void Main()  
    {  
        int result = 0;  
        //Displays all disarium numbers in range  
        Console.WriteLine("Disarium numbers in a range: ");  
        Console.Write("Enter lower limit: ");
        int lower = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter upper limit: ");
        int upper = Convert.ToInt32(Console.ReadLine());
        for(int i = lower; i <= upper; i++){  
            result = sumOfDigits(i);  
            if(result == i)  
                Console.Write(i + " ");  
        }  
    }  
}  
