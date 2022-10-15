/*
Pronic Number: pronic number can be defined as the number which is a product of two consecutive numbers, its repesented as N = N(N+1)
Ex: 6=2X3, 72 =8X9
*/
using System;  
                      
public class PronicNumbers  
{  
    //isPronicNumber() will determine whether a given number is pronic number or not  
    public static Boolean isPronicNumber(int num){  
        Boolean flag = false;  
          
        for(int j = 1; j <= num; j++){  
            //Checks for pronic number by multiplying consecutive numbers  
            if((j*(j+1)) == num){  // pronic number definition (N=N(N+1))
                flag = true;  
                break;  
            }  
        }  
        return flag;  
    }  
      
    public static void Main()   
    {  
        //Displays pronic numbers range   
        Console.WriteLine("Pronic numbers in range:  ");
        Console.Write("Enter lower limit: ");
        int lower = int.Parse(Console.ReadLine()); // get lower limit 
        Console.Write("Enter upper limit: ");
        int upper = int.Parse(Console.ReadLine()); // get upper limit 
        for(int i = lower; i <= upper; i++){  
            if(isPronicNumber(i))  // calling function by passing the index as parameter 
                Console.Write(i + " ");  
        }  
    }  
}   
