using System;
public class Employee{
    public int id;
    public string name;
    public float salary;
    public Employee(int i,string n,float s){
        id = i;
        name = n;
        salary = s;
    }
    public void display(){
        Console.WriteLine(id+" "+name+" "+salary);
    }
}
class Test{
    public static void Main(string[] args){
        Employee e1 = new Employee(101,"S",90000f);
        Employee e2 = new Employee(102,"A",90003f);
        e1.display();
        e2.display();
    }
}
