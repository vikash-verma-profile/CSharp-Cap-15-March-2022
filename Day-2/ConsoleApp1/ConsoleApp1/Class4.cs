using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class4
    {
        //Arrays
        public static void Main()
        {
            /*
             * <data type> [] <Name_Array>
             */
            int[] x;
            int[] x1 = new int[5];
            int[] x2 = new int[] { 1, 2, 3, 4 };
            int[] x4 = new int[2];

            Console.WriteLine("Please enter some values in array");
            //x4[0]=Convert.ToInt32(Console.ReadLine());
            //x4[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("x[0]==>"+x4[0]);
            //Console.WriteLine("x[1]==>" + x4[1]);

            for (int i = 0; i < x4.Length; i++)
            {
                x4[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < x4.Length; i++)
            {
                Console.WriteLine("x["+i+"]==>" + x4[i]);
            }
        }
    }
}
