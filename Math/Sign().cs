using System;
class Sample
{
    //Entry point of Program
    static public void Main()
    {
        int ret = 0;
        ret = Math.Sign(-52m);
        if (ret == 0)
            Console.WriteLine("Equal to zero");
        else if(ret==-1)
            Console.WriteLine("Less than zero");
        else
            Console.WriteLine("Greater than zero");
        ret = Math.Sign(52m);
        if (ret == 0)
            Console.WriteLine("Equal to zero");
        else if (ret == -1)
            Console.WriteLine("Less than zero");
        else
            Console.WriteLine("Greater than zero");
    }
}
