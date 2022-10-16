/*
 * C# Program to Perfom Currency Conversions
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter your Choice :\n 1- Dollar to Rupee \n 
                               2- Euro to Rupee \n 3- Yen to Rupee ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
            case 1:
                 Double dollar, rupee,val;
                 Console.WriteLine("Enter the Dollar Amount :");
                 dollar = Double.Parse(Console.ReadLine());
                 Console.WriteLine("Enter the Dollar Value :");
                 val = double.Parse(Console.ReadLine());
                 rupee = dollar * val;
                 Console.WriteLine("{0} Dollar Equals {1} Rupees", dollar, rupee);
                 break;
            case 2:
                 Double Euro, rupe,valu;
                 Console.WriteLine("Enter the Euro Amount :");
                 Euro = Double.Parse(Console.ReadLine());
                 Console.WriteLine("Enter the Euro Value :");
                 valu = double.Parse(Console.ReadLine());
                 rupe = Euro * valu;
                 Console.WriteLine("{0} Euro Equals {1} Rupees", Euro, rupe);
                 break;
            case 3:
                 Double yen, rup,value;
                 Console.WriteLine("Enter the Yen Amount :");
                 yen = Double.Parse(Console.ReadLine());
                 Console.WriteLine("Enter the Yen Value :");
                 value = double.Parse(Console.ReadLine());
                 rup = yen * value;
                 Console.WriteLine("{0} Yen Equals {1} Rupees", 
                                   yen, rup);
                 break;
           }
           Console.ReadLine();
        }
    }
}
