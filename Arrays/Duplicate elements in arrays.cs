
    
using System;                        
public class DuplicateElement  
{  
    public static void Main()  
    {  
        //Initialize array   
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());
        int [] arr = new int [size];
        Console.Write($"Input  elements at {size} position in the array :\n");  
    for(int i=0; i<size; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());  		
    }   
     Console.WriteLine("Duplicate elements in given array: ");  
        //Searches for duplicate element  
        for(int i = 0; i < arr.Length; i++) {  
            for(int j = i + 1; j < arr.Length; j++) {  
                if(arr[i] == arr[j])  
                    Console.WriteLine(arr[j]);  
            }  
        }  
    }  
}  
