using System;

class Program
{
    static void Main() {
     int a, b, i, Sum = 0;
     Console.Write("Enter lower limit of range: ");
     int lower = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter upper limit of range: ");
     int upper = Convert.ToInt32(Console.ReadLine());
        for (i = lower; i < upper; i++)
        {
            a = i % 3;
            b = i % 5;
            if (a == 0 || b == 0)
            {
                Console.Write("{0}\t", i);
                Sum = Sum + i;
            }
        }
        Console.WriteLine("\nThe Sum of all the Multiples of 3 or 5 Below 100 : {0}", 
                          Sum);
        Console.Read();
       
    }
}
