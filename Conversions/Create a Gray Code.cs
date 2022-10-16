/*
 * C# Program to Create a Gray Code
 */
using System;
public class Gray
{
    public static ulong grayEncode(ulong n)
    {
        return n ^ (n >> 1);
    }
 
    public static ulong grayDecode(ulong n)
    {
        ulong i = 1 << 8 * 64 - 2; //long is 64-bit
        ulong p, b = p = n & i;
 
        while ((i >>= 1) > 0)
            b |= p = n & i ^ p >> 1;
        return b;
    }
 
    public static void Main(string[] args)
    {
        Console.WriteLine("Number\tGray");
        for (ulong i = 0; i < 10; i++)
        {
            Console.WriteLine(string.Format("{0}\t{1}", i, 
                              Convert.ToString((long)grayEncode(i), 2)));
 
        }
        Console.Read();
    }
}
