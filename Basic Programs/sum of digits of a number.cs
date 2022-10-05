using System;

class Program
{
    static void Main() {
     int sum = 0, r;
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : "+sum);
            Console.Read();
       
    }
}
