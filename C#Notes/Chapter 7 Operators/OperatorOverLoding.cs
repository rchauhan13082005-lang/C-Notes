
using System;

namespace C_Notes.Chapter_7_Operators
{
    class Vector
    {
        public int X;
        public int Y;

        public Vector(int x , int y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector
            (
                a.X = b.X,
                a.Y = b.Y
            );
            
        }

        public override string 


    }



    class OperatorOverLoding
    {
        static void Main()
        {
            //checked & unchecked convertion//
            //Checked//
            try
            {
                checked
                {
                    byte num = 255;

                    num++;

                    Console.WriteLine(num);
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow occurred");
            }

            //unchecked //
            unchecked
            {
                byte number = 255;

                number++;

                Console.WriteLine(number);
            }

        }
    }
}
