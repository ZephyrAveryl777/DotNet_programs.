using System;

 class HelloWorld
{
     static void Main(string[] args)
    {
    int i;
    Console.Write("Enter the range:");
    int range=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("odd numbers in range");
    for(i=1;i<range;i++)
    {
        if(i%2==1)
        Console.WriteLine(i+"\t");
    }
        Console.WriteLine("Even numbers in range");
        for(i=1;i<range;i++)
    {
        if(i%2==0)
        Console.WriteLine(i+"\t");
    }
        
    }
