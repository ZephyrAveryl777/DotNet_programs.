using System;
public class Employee{
    public Employee(){
        Console.WriteLine("Default Constructor Invoked");
    }
}
class Test{
    public static void Main(String[] args){
        Employee e1 = new Employee();
        Employee e2 = new Employee();
    }
}
