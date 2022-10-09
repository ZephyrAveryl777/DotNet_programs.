using System;
public class Employee{
    public int id;
    public String name;
    public float salary;
    public void insert(int i,string n,float s){
        id = i;
        name =n;
        salary=s;
    }
    public void display(){
        Console.WriteLine(id+" "+name+" "+salary);
    }
}
class Test{
    public static void Main(string[] args){
        Employee t1 = new Employee();
        Employee t2 = new Employee();
        t1.insert(100,"A",90000f);
        t2.insert(200,"B",80000f);
        t1.display();
        t2.display();
    }
}
