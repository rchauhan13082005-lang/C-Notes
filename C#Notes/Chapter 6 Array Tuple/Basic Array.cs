using System;
using System.Collections.Generic;
using System.Text;

namespace C_Notes.Chapter_6_Array_Tuple
{
   class Program
    {
        static void Main()
        {
            //Initializing Array//
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            //Initilizer Array 2//
            int[] number2 = { 10, 20, 30, 40 };
            Console.WriteLine(number2);

            //Initilization Array 3//
            int[] a = new int[] { 10, 20, 30, 40 };


            //Initilization Array with for Loop//
            int[] marks = { 80, 75, 90, 65, 89 };

            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

            // multidimentional Initilization Array 2D //
            int[] Marks = { 80, 75, 90, 65, 89 };

            foreach(int mk in marks)
            {
                Console.WriteLine(mk);
            }

            int[,] array = new int[3, 3];

            array[0, 0] = 10;
            array[0, 1] = 20;
            array[0, 2] = 30;

            array[1, 0] = 40;
            array[1, 1] = 50;
            array[1, 2] = 60;

            array[2, 0] = 70;
            array[2, 1] = 80;
            array[2, 2] = 90;

            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[1, 2]);
            Console.WriteLine(array[2, 2]);

            //Jagged Array//
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[3];

            jaggedArray[0][0] = 10;
            jaggedArray[0][1] = 20;

            jaggedArray[1][0] = 30;
            jaggedArray[1][1] = 40;
            jaggedArray[1][2] = 50;
            jaggedArray[1][3] = 60;

            jaggedArray[2][0] = 70;
            jaggedArray[2][1] = 80;
            jaggedArray[2][2] = 90;

            Console.WriteLine(jaggedArray[0][1]);
            Console.WriteLine(jaggedArray[1][3]);
            Console.WriteLine(jaggedArray[2][1]);
        }

    }
}
