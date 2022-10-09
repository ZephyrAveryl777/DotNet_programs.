using System;
namespace Program{
    class Employee{
        string department;
        static void Main(string[] args){
            Employee s = new Employee();
            s.department = "Development";
            Console.WriteLine("Department of Sam is: {0}",s.department);
            Employee s1 = new Employee();
            s1.department = "Content Writing";
            Console.WriteLine("Taylor: {0}",s1.department);
        }
    }
}
