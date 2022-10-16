using System;

class Sample
{
    //Entry point of Program
    static public void Main()
    {
        double AreaOfCircle = 0.0;
        int radius = 12;

        AreaOfCircle = (Math.PI * radius * radius);

        System.Console.WriteLine("Area of Circle: "+AreaOfCircle);
    }
}
