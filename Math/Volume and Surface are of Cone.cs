/*
 * C# Program to find Volume and Surface Area of a Sphere
 */
using System;
using System.IO;
class program
{
    public static void Main()
    {
        double r, surface_area, volume;
        double PI = 3.14;
        Console.WriteLine("Enter the Radius of the Sphere: ");
        r = Convert.ToDouble(Console.ReadLine());
        surface_area =  4* PI * r * r;
        volume = (4.0 / 3) * PI * r * r * r;
        Console.WriteLine("Surface Area of Sphere is : {0} ", surface_area);
        Console.WriteLine("Volume of Sphere is : {0}", volume);
        Console.Read();
    }
}
