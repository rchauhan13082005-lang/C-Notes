using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
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

        }
    }
}
