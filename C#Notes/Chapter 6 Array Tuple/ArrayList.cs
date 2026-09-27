using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_Notes.Chapter_6_Array_Tuple
{
    class ArrayListBuilding 
    {
        static void Main()
        {
            ArrayList data = new ArrayList();

            data.Add("Rajat");
            data.Add(21);
            data.Add(85.5);
            data.Add(true);

            foreach(Object item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
