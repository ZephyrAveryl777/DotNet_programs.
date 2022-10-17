using System;  
                      
public class CopyArray  
{  
    public static void Main()  
    {  
        //Initialize array   
        int [] arr1 = new int [] {1, 2, 3, 4, 5};   
          
        //Create another array arr2 with size of arr1  
        int [] arr2 = new int[arr1.Length];  
          
        //Copying all elements of one array into another  
        for (int i = 0; i < arr1.Length; i++) {   
            arr2[i] = arr1[i];   
        }    
          
        //Displaying elements of array arr1   
        Console.WriteLine("Elements of original array: ");  
        for (int i = 0; i < arr1.Length; i++) {   
           Console.Write(arr1[i] + " ");  
        }   
          
        Console.WriteLine();  
          
        //Displaying elements of array arr2   
        Console.WriteLine("Elements of new array: ");  
        for (int i = 0; i < arr2.Length; i++) {   
           Console.Write(arr2[i] + " ");  
        }   
    }  
}  

