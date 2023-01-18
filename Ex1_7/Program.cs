using System;

namespace MyApplication
{
    class Member
    {
        public string name = "";
        public int age;
        public long phonenumber;
        public string address = "";
        public double salary;
        public void printSalary()
        {
            Console.WriteLine(salary);
        }

    }
    class Employee : Member
    {
        public string specialization  ="";

    }

    class Manager : Member
    {
        public string department = "";

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "Jenny";
            emp.age = 25;
            emp.phonenumber = 1234567890;
            emp.address = "India";
            emp.salary = 20000;
            emp.specialization = "dotnet";
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.age);
            Console.WriteLine(emp.phonenumber);
            Console.WriteLine(emp.address);
            emp.printSalary();
            Console.WriteLine(emp.specialization);

            Console.WriteLine();

            Manager mng = new Manager();
            mng.name = "Smith";
            mng.age = 22;
            mng.phonenumber = 9988776612;
            mng.address = "U.S.A";
            mng.salary = 100000;
            mng.department = "Product Devlopment";
            Console.WriteLine(mng.name);
            Console.WriteLine(mng.age);
            Console.WriteLine(mng.phonenumber);
            Console.WriteLine(mng.address);
            Console.WriteLine(mng.salary);
            Console.WriteLine(mng.department);
            
           
        }
    }

}