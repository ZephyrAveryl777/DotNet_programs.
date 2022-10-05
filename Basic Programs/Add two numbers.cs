using System;

class Program
{
    static void Main() {
        Console.WriteLine("Program to add two numbers");
        string header = new String('-',30);
        Console.WriteLine(header);
        Console.Write("Enter a Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int total = num1 + num2;
        string footer = new String('-',30);
        Console.WriteLine(footer);
        Console.WriteLine("Total of two numbers is: {0}",total);
        string footer2 = new String('-',30);
        Console.WriteLine(footer2);
    }
}
