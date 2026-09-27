using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C_Notes.Chapter_6_Array_Tuple
{
    //Array Can Passing as paramerter
    class ArrayPassing
    {
        static void PrintArray(int[] numbers)
        {
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            PrintArray(numbers);
        }
    }
}
