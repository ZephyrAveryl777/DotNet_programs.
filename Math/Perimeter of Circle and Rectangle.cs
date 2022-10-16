/*
 * C# Program to Calculate Perimeter of Circle and Rectangle
 */
using System;
using System.IO;
class program
{
    public static void Main()
    {
 
        double l,b,r,per_rect,per_cir;
        double PI = 3.14;
        Console.WriteLine("Enter the Length and Breadth : ");
        l = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        per_rect = 2 * (l + b);
        Console.WriteLine("Enter the radius of the circle : ");
        r = Convert.ToDouble(Console.ReadLine());
        per_cir = 2 * PI * r;
        Console.WriteLine("Perimeter of Rectangle : {0}", per_rect);
        Console.WriteLine("Perimeter of Circle : {0}", per_cir);
        Console.Read();
    }
}
