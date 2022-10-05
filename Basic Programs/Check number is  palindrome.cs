using System;

class Program
{
    static void Main() {
     int remainder, reverse = 0;
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        int temp = num;
        while (num > 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num /= 10;
            
        }
        Console.WriteLine("Given number is = {0}", temp);
        Console.WriteLine("Its reverse is  = {0}", reverse);
        if (temp == reverse)
            Console.WriteLine("Number is a palindrome \n");
        else
            Console.WriteLine("Number is not a palindrome \n");
        Console.ReadLine();
    }
}
