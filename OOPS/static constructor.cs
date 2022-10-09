using System;
public class Account {
    public int id;
    public string name;
    public static float rate;
    public Account(int id, String name){
         this.id=id;
         this.name=name;
    }
    static Account(){
        rate = 9.5f;
    }
    public void display(){
        Console.WriteLine(id+" "+name+" "+rate);
    }
}
class Test{
    public static void Main(string[] args){
        Account a1 = new Account(101,"A");
        Account a2 = new Account(102,"S");
        a1.display();
        a2.display();
    }
}
