using System;
public class Student{
    int id; 
    String name;

public static void Main(String[] args){
    Student s1 = new Student();
    s1.id=100;
    s1.name = "A";
    Console.WriteLine(s1.id);
    Console.WriteLine(s1.name);
}    
}
