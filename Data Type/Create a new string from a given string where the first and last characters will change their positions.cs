using System;
using System.Collections.Generic;
namespace Program{
public class Exercise16 {
  static void Main(string[] args)
        {
            // function call with string passing as parameter 
            Console.WriteLine(Letter("Hello"));
            Console.WriteLine(Letter("Python"));
            Console.WriteLine(Letter("A"));
        }
       public static string Letter(string ustr)
        {
            return ustr.Length > 1 // use of terneary operator(short hand if else) for finding substring 
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
}
}
