/*
 *  C# Program to Convert Big Endian to Little Endian
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication4
{
    class Program
    {
        static int ReverseBytes(int val)
        {
            byte[] intAsBytes = BitConverter.GetBytes(val);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt32(intAsBytes, 0);
        }
        static string IntToBinaryString(int v)
        {
            string s = Convert.ToString(v, 2); 
            string t = s.PadLeft(32, '0'); 
            string res = ""; 
            for (int i = 0; i < t.Length; ++i)
            {
                if (i > 0 && i % 8 == 0)
                    res += " "; 
                res += t[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter little edian value: ");
            int little = Convert.ToInt32(Console.ReadLine()); 
            int big = ReverseBytes(little);
            string sLittle = IntToBinaryString(little);
            string sBig = IntToBinaryString(big);
            int oLittle = ReverseBytes(big);
            string oString = IntToBinaryString(oLittle);
            Console.WriteLine("Original (Intel) little endian value = "
              + little);
            Console.WriteLine("Original value as binary string = "
              + sLittle);
            Console.WriteLine("");
            Console.WriteLine("Reversed big endian value = "
              + big);
            Console.WriteLine("Reversed value as string = "
              + sBig);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
