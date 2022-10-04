using System;

class Program
{
     static void Main(string[] args)
Console.WriteLine("option 1 => Celcius to Farenheit\n option 2 => farenheit to celcius\n");
     Console.WriteLine("Enter the option: ");
     int option=Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
    case 1:
     Console.WriteLine("Enter the celcius: ");
    int c1=Convert.ToInt32(Console.ReadLine());
    int f1=(c1*9/5)+32;
    Console.WriteLine("farenheit Degree is: "+f1);
    break;
    case 2:
    Console.WriteLine("Enter the farenheit: ");
    int f = Convert.ToInt32(Console.ReadLine());
    int c=(f-32)*5/9;
    Console.WriteLine("Celcius Degree is: "+c);
    break;
    }
    
    
    
    
    }
}
// Console.WriteLine("Converting Celcius to farenheit");
    // Console.WriteLine("Enter the celcius");
    // int c=Convert.ToInt32(Console.ReadLine());
    // int f=(c*9/5)+32;
    // Console.WriteLine("farenheit Degree is :"+f);
    // Console.WriteLine("Converting Celcius to farenheit");
    // Console.WriteLine("Enter the farenheit");
    // int c=Convert.ToInt32(Console.ReadLine());
    // int f=(c*9/5)+32;
    // Console.WriteLine("Celcius Degree is :"+c)
