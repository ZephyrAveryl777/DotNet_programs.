//Program to demonstrate the 
//example of the left-shift operator in C#.

using System;

class LeftShiftDemo
{
    public static void Main()
    {
        int X = 128;
        int Y = 256;

        int R = 0;

        R = X << 2;
        Console.WriteLine("X<<2 = " + R);

        R = Y << 3;
        Console.WriteLine("Y<<3 = " + R);
    }
}

//Program to demonstrate the 
//example of right shift operator in C#.

//using System;

class RightShiftDemo
{
    public static void Main()
    {
        int X = 128;
        int Y = 256;

        int R = 0;

        R = X >> 2;
        Console.WriteLine("X>>2 = " + R);

        R = Y >> 3;
        Console.WriteLine("Y>>3 = " + R);
    }
}
