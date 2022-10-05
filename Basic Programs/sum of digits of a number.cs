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

// using Recursion
using System;

class Program
{
     public static void Main()
{
    int num, result;
    Recursion rc = new Recursion();
    Console.Write("Enter the Number : ");
    num=int.Parse(Console.ReadLine());
    result =rc.sum(num);
    Console.WriteLine("Sum of Digits of {0} is {1}", num, result);
    Console.Read();
}
}
class Recursion
{
    public int sum(int num)
    {
        if (num != 0)
        {
            return (num % 10 + sum(num / 10));
        }
        else
        {
            return 0;
        }
    }
}
