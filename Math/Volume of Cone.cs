/*
 * C# Program to Calculate Area and Volume of a Cone
 */
using System;
using System.IO;
class program
{
    public static void Main()
    {
        double r, h, surface_area, volume;
        double PI = 3.14;
        Console.WriteLine("Enter the Radius and Height of a cone : ");
        r = Convert.ToDouble(Console.ReadLine());
        h = Convert.ToDouble(Console.ReadLine());
        surface_area = PI * r * (r + Math.Sqrt(r * r + h * h));
        volume = (1.0 / 3) * PI * r * r * h;
        Console.WriteLine("Surface Area of cone is : {0} ", surface_area);
        Console.WriteLine("Volume of Cone is : {0}", volume);
        Console.Read();
    }
}
