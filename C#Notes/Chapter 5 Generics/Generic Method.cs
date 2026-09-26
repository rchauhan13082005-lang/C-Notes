using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C_Notes.Chapter_5_Generics
{
    public class Utility
    {
        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
    class Program
    {
        //Practice Methods 1//
        static void PrintValue<T>(T value)
        {
            Console.WriteLine(value);
        }
        //Practice Methods 2//
        static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = first;
        }
        //Practice Generic Method 3//
        static T GetMaximum<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            return b;
        }
        //Practice Generic Method 4//
        static int FindIndex<T>(T[]array, T value)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (Equals(array[i],value))
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main()
        {
          var uti = new Utility();
            int a = 12;
            int b = 14;

            uti.Swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);

            string x = "Rajat";
            string y = "Chauhan";

            uti.Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);


            //Practice Generic Method 1//
            PrintValue<int>(100);
            PrintValue<string>("Hello");
            PrintValue<double>(10.5);
            PrintValue<bool>(true);

            //Practice Generic Method 2//
            int A = 10;
            int B = 20;

            Swap(ref A, ref B);

            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");

            string X = "Hello";
            string Y= "World";

            Swap(ref X, ref Y);

            Console.WriteLine(X);
            Console.WriteLine(Y);

            //Practice Generic Method 3//
            int result = GetMaximum(10, 20);
            double result2 = GetMaximum(25.5, 15.2);
            string result3 = GetMaximum("Apple", "Banana");

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            //Practice Generic Method 4//
            int[] number = { 10, 20, 30, 40, 50 };

            int index = FindIndex(number, 30);

            Console.WriteLine($"Index:{index}");

            string[] names =
            {
                "Rajat",
                "Aman",
                "Krishna",
                "Abhishak"
            };

            int nameIndex = FindIndex(names, "Krishna");
            Console.WriteLine($"Index:{nameIndex}");
        }
    }
}
