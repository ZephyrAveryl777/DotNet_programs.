/*
 * C# Program to calculate the series sin(x)=x-x^3/3!+x^5/!-x^7/7!+......
 */
using System;
class sine
{
    int deg, n;
    public void readdata()
    {
        Console.WriteLine("Enter the Number of Terms:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Angle in Degrees:");
        deg = Convert.ToInt32(Console.ReadLine());
    }
    public void sineseries()
    {
        float x, s = 0.0f, t;
        x = (float)Math.PI * deg / 180f;
        s = x;
        t = x;
        for (int i = 1; i <= n; i++)
        {
            t = (-t * x * x) / ((2 * i) * (2 * i + 1));
            s = s + t;
        }
        Console.WriteLine("Sin({0})={1}", deg, s);
    }
    public static void Main()
    {
        sine s = new sine();
        s.readdata();
        s.sineseries();
    }
}
