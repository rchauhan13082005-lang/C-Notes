using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace C_Notes.Chapter_5_Generics
{
    //Generic Class with Default keyword//
    class DataStore<T>
    {
        private T data = default(T);

        public T GetData()
        {
            return data;
        }
        public void setData(T data)
        {
            this.data = data;
        }
    }
    // Generic Constrants//
    class Student
    {
        public string Name { get; set; }

    }

    class ProgramGeneric 
    {
        //Default using Generic//
        static T GetDefualt<T>()
        {
            return default(T);
        }

        //Generic Constraints//
        static void show<T>(T value) where T : class
        {
            Console.WriteLine(value);
        }
        static void Main()
        {
            int number = GetDefualt<int>();
            string name = GetDefualt<string>();
            bool status = GetDefualt<bool>();

            Console.WriteLine($"int  :{number}");
            Console.WriteLine($"string:{name}");
            Console.WriteLine($"bool:{status}");

            //Generic class with Default keword//
            DataStore<int> intstore = new DataStore<int>();
            Console.WriteLine(intstore.GetData());

            DataStore<string> stringStore = new DataStore<string>();
            Console.WriteLine(intstore.GetData());

            //Generic constraints //
            Student student = new Student
            {
                Name = "Rajat"
            };
            show(student);

            show("Hello");

        }
    }
}
