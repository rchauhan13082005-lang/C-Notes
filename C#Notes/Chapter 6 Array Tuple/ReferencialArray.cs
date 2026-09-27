using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace C_Notes.Chapter_6_Array_Tuple
{
    class Person
    {
        public string Name { get; set; }
    }
    //yeild keyword//
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

    }
    class ProgramArray
    {
        static IEnumerable<Student> GetPassedStudents(List<Student> students)
        {
            foreach(Student student in students)
            {
                if (student.Marks >= 40)
                {
                    yield return student;
                }
            }
        }
        
        static void Main()
        {
            Person[] people = new Person[3];

            people[0] = new Person { Name = "Rajat" };
            people[1] = new Person { Name = "Abhishek" };
            people[2] = new Person { Name = "Sagar" };

            foreach(Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            List<Student> students = new List<Student>()
            {
                new Student { Name = "Rajat" , Marks = 83 },
                new Student { Name = "Ayush" , Marks = 35 },
                new Student { Name = "Deepak" ,Marks = 90 },
                new Student { Name = "Sam" ,Marks = 28}
            };
            IEnumerable<Student> PassedStudent = GetPassedStudents(students);

            foreach(Student student in PassedStudent)
            {
                Console.WriteLine($"{student.Name},{student.Marks}");
            }
        }
    }
}
