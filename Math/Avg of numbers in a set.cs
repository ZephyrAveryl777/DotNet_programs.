/*
 * C# Program to Find the Mean of given Set of Numbers
 */
using System;
class avg
{
    public static void Main()
    {
        int n1, n2, n3, n4, n5, avg, sum;
        Console.WriteLine("Enter 5 Numbers:");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());
        sum = (n1 + n2 + n3 + n4 + n5);
        avg = (sum / 5);
        Console.WriteLine("Sum :" + sum);
        Console.WriteLine("Average :" + avg);
        Console.ReadLine();
    }
}
