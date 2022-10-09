using System;
public class Account{
    public int acc;
    public string name;
    public static int count = 0;
    public Account(int acc,string name){
        this.acc = acc;
        this.name = name;
        count++;
    }
    public void display(){
        Console.WriteLine(acc+" "+name);
    }
}
class Test{
    public static void Main(string[] args){
        Account a1 = new Account(101,"S");
        Account a2 = new Account(102,"A");
        Account a3 = new Account(103,"X");
        a1.display();
        a2.display();
        a3.display();
        Console.WriteLine("Total No. of Objects are: "+Account.count);
    }
}
