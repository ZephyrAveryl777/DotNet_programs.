using System;
public static class Mathz{
    public static float Pi = 3.14f;
    public static int cube(int n){return n*n*n;}
}
class Test{
    public static void Main(string[] args){
        Console.WriteLine("Value of PI: "+Mathz.Pi);
        Console.WriteLine("Cube of 3 is: "+Mathz.cube(3));
    }
}
