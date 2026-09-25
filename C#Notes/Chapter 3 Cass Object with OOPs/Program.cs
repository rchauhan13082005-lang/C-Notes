using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Versioning;
using System.Text;
namespace Chapter3
{
    // Chapter 3 - Class/Object
    // Topic 1 - basic class //
    public class Student
    {
        //fields & Properties//
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor//
        public Student(int id, string name, int age)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        //Method//
        public void Study()
        {
            Console.WriteLine($"Student is studying.");
        }
    }
    //Topic 2 - Struct//
    public struct Teacher
    {
        //fields & Properties//
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor//
        public Teacher(int id, string name, int age)
        {
            Id = id;
            Age = age;
            Name = name;
        }
        //Method//
        public void Teach()
        {
            Console.WriteLine($"Teacher{Name} is teaching");
        }

    }
    //Topic 3 - Performing operations of 4 pillars of OOP - Encapsulation, Inheritance, Polymorphism, Abstraction//

    //Encapsulation //
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public String Address { get; private set; }
       
        public Person(string name, int age, string address)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null here");
            }
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be nagative");
            }
            Name = name;
            Age = age;
            Address = address;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }

    // Abstract\Inheritance//
    public abstract class Employee 
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        public Employee (string name, int employeeId)
        {
            Name = name;
            EmployeeId = employeeId;
        }

        public abstract void PerformWork();
       
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}, Employee ID: {EmployeeId}");
        }

        
    }
    public class Manager : Employee
    {
        public Manager(string name, int employeeId) : base(name, employeeId)
        {

        }
        public override void PerformWork()
        {
            Console.WriteLine("Manager is managing the team.");
        }
    }
    //Poymorphism//
    public class EmployeeAdmin 
    {
        public void CalculateSalary(int basicSalary)
        {
            Console.WriteLine($"Salary: {basicSalary}");
        }
        public void CalculateSalary(int basicSalary, int bonus)
        {
            Console.WriteLine($"Salary: {basicSalary + bonus}");
        }
        public void CalculateSalary(int basicSalary, int bonus, int allowance)
        {
            Console.WriteLine($"Salary: {basicSalary + bonus + allowance}");
        }
    }
    //Overriding //
    public class Vehicle
    {
        public virtual void Sound()
        {
            Console.WriteLine("vehicle sound");
        }
    }
    public class Car : Vehicle
    {
        public override void Sound()
        {
            Console.WriteLine("Car sound ");
        }
    }
    class Program
    {
        public static void Main()
        {
            // Object Creation - Topic 1//
            Student stu = new Student(1001, "Rajat", 21);
            stu.Study();

            //Object Creation - Topic 2//
            Teacher tch = new Teacher(1210, "Vikas", 30);
            tch.Teach();

            //Object Creation - Topic 3//
            Person person = new Person("Rajat", 21, "Delhi");
            person.DisplayInfo();
            //Object Creation - Topic 4//
            var mng = new Manager("John Doe", 1001);
            mng.PerformWork();
            //Object Creation - Topic 5//
            var Emp = new EmployeeAdmin();

            Emp.CalculateSalary(30000);
            Emp.CalculateSalary(30000 + 5000);
            Emp.CalculateSalary(30000 + 5000 + 3000);

            var veh = new Vehicle();
            var car = new Car();
            veh.Sound();
            car.Sound();
        }
    }
}
