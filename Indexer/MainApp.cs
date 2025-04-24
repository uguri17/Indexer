using System;
using System.Collections;
using static System.Console;

namespace Indexer
{
    class MyList
    {
        private int[] array; //= new int[3];

        public MyList()
        {
            array = new int[3];
        }
        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public int this[int index]
        {       // Indexer
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    WriteLine($"Array Resized: {array.Length}");
                }

                array[index] = value;
            }
        }        
    }  
    
    class MainApp
    {
        static void Main(string[] args)
        {            
            MyList list = new MyList();
            WriteLine(list.Length);

            for (int i = 0; i < 5; i++)
            {
                list[i] = i;
            }
        }
    }
}