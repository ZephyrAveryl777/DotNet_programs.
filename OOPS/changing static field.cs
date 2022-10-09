using System;
public class Account{
    public int acc;
    public string name;
    public static float rate = 8.5f;
    public Account(int acc, string name){
        this.acc = acc;
        this.name=name;
    }
    public void display(){
        Console.WriteLine(acc+" "+name+" "+rate);
    }
}
class Test{
    public static void Main(string[] args){
        Account a1 = new Account(101,"S");
        Account a2 = new Account(102,"A");
        a1.display();
        a2.display();
    }
}
