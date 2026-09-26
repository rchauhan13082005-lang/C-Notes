using System;
using System.Collections.Generic;
using System.Text;

namespace C_Notes.Chapter_5
{
    //Chapter 5 - Generic 
    // Generic Class //
    public class DataStore<T>
    {
        private T data ;
        public DataStore(T value)
        {
            data = value;
        }
      
        public T GetValue()
        {
            return data;
        }
    }
    class Program
    {
        static void Main()
        {
            DataStore<int> intStore = new DataStore<int>(100);
           
            Console.WriteLine(intStore.GetValue());

            DataStore<string> stringStore = new DataStore<string>("Rajat");
            Console.WriteLine(stringStore.GetValue());

        }
    }

}