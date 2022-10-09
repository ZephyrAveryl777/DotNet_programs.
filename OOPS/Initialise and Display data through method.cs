using System;
public class Student{
    public int id;
    public string name;
    public void insert(int i,string n)
    {
        id =i;
        name=n;
    }
    public void display(){
        Console.WriteLine(id+" "+name);
    }
}
class Test{
    public static void Main(string[] args){
        Student s1 = new Student();
        Student s2 = new Student();
        s1.insert(100,"a");
        s2.insert(200,"b");
        s1.display();
        s2.display();
    }
}
