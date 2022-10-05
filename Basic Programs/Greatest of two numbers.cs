using System;

class Program
{
    static void Main() {
       Console.Write("Enter first number: ");
       int a = Convert.ToInt32(Console.ReadLine());
       Console.Write("Enter second number: ");
       int b = Convert.ToInt32(Console.ReadLine());
       string header = new String('-',25);
       Console.WriteLine(header);
       if (a > b)
        {
            Console.WriteLine("{0} is the Greatest Number", a);
        }
        else
        {
            Console.WriteLine("{0} is the Greatest Number ", b);
        }
        Console.ReadLine();
       
    }
}
