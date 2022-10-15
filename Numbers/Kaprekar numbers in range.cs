/*
Kaprekar Numbers: A non-negative integer having base(10) is said to be the Kaprekar number if the representation of its square in its base can be split into two parts that add up to the original number, with the condition that the part formed from the low-order digits of the square must be non-zero-however, it is allowed to include leading zeroes.
45 =  (45)^2 = 2025 =20 + 25 -45
1 = 12 = 01 = 0 + 1 = 1
*/
using System;  
public class Kaprekar {   
    static bool iskaprekar(int n)   
    {   
        if (n == 1)   
            return true;   
    int sq_n = n * n;   
        int count_digits = 0;   
        while (sq_n != 0) {   
            count_digits++;   
            sq_n /= 10;   
        }   
        sq_n = n * n;    
        for (int r_digits = 1; r_digits < count_digits; r_digits++)   
        {   
            int eq_parts = (int)Math.Pow(10, r_digits);   
            if (eq_parts == n)   
                continue;   
            int sum = sq_n / eq_parts + sq_n % eq_parts;   
            if (sum == n)   
                return true;   
        }   
           return false;   
    }    
    public static void Main()   
    {   
        for (int i = 1; i < 100; i++)   
            if (iskaprekar(i))   
                Console.Write(i + " ");   
    }   
}  
