using System;

class Program
{
    static void Main() {
        Console.WriteLine("Program to Multiply two numbers");
        Console.Write("Enter a floating point number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter a floating point number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());
        float total = num1*num2;
        Console.WriteLine("Product of fist Number: {0}, second Number {1} is {2}", num1, num2, total);
    }
}
