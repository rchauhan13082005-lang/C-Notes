using System;
using System.Collections.Generic;
using System.Text;

namespace C_Notes.Chapter_6_Array_Tuple
{
    class TuplePractice
    {
        static void Main()
        {
            Tuple<int, string> student = new Tuple<int, string>(101, "Rajat");
            Console.WriteLine(student.Item1);
            Console.WriteLine(student.Item2);
        }
    }
}
