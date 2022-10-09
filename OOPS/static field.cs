using System;
public class Account{
    public int accno;
    public string name;
    public static float interestRate=8.8f;
    public Account(int accno,string name){ // parametrized constructor
        this.accno = accno;
        this.name=name;
    }
    public void display(){
        Console.WriteLine(accno+" "+name+" "+interestRate);
    }
    class Test{
        public static void Main(string[] args){
            Account a1 = new Account(101,"S");
            Account a2 = new Account(102,"A");
            a1.display();
            a2.display();
        }
    }
}
