/*
 * C# Program to Find the Cube Root of a Given Number
 */
using System;
class CubeRoot
{
    public static void Main()
    {
        Console.Write("Enter the Number : ");
        double num = double.Parse(Console.ReadLine());
        double res = Math.Ceiling(Math.Pow(num, (double)1 / 3));
        Console.Write("Cube Root : " + res);
 
    }
}
