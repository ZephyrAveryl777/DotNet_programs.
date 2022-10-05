using System;

class Program
{
     static void Main(string[] args)
        {
            Console.Write("Enter the Character : ");
            char a = Convert.ToChar(Console.ReadLine());
            int i = (int)a;
            if (i >= 65 && i <= 90)
            {
 
                Console.WriteLine("The Character is : {0}", char.ToLower(a));
 
            }
            else if (i >= 97 && i <= 122)
            {
                Console.WriteLine("The Character is : {0}", char.ToUpper(a));
            }
            Console.Read();
        }
}
