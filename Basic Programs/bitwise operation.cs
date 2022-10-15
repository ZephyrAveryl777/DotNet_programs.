// C# program to demonstrate example of
// bitwise operators
using System;
using System.IO;
using System.Text;

namespace Program
{
    class Test
    {
        // Main Method
        static void Main(string[] args)
        {

            int a = 10;
            int b = 3;
            int result = 0;

            result = a & b;     //1010 & 0011 = 0010 = 3
            Console.WriteLine("a & b  : {0}", result);

            result = a | b;     //1010 | 0011 = 1011 = 11
            Console.WriteLine("a | b  : {0}", result);

            result = a ^ b;     //1010 ^ 0011 = 1001
            Console.WriteLine("a ^ b  : {0}", result);

            result = ~a;        //ones compliment of 10
            Console.WriteLine("~a     : {0}", result);

            result = a << 2;    //1010<<2 = 101000 = 40
            Console.WriteLine("a << b : {0}", result);

            result = a >> 2;    //1010>>2 = 0010 = 2
            Console.WriteLine("a >> b : {0}", result);

            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
