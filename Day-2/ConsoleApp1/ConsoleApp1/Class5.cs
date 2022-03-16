using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class5
    {
        /*
         * Jagged array=>array of arrays
         */
        public static void Main5()
        {
            //<data-type> [][] <name of array>=new <data-type>[rows][]
            int [][] jagged_arry=new int[4][];
            jagged_arry[0] = new int[2] { 1, 2 };
            jagged_arry[1] = new int[3] { 11, 21,89 };
            jagged_arry[2] = new int[4] { 445, 43,90,91 };
            jagged_arry[3] = new int[2] { 89, 90 };

            for (int i = 0; i < jagged_arry.Length; i++)
            {
                for (int k = 0; k < jagged_arry[i].Length; k++)
                {
                    Console.Write(jagged_arry[i][k]+",");
                }
                Console.WriteLine();
            }
        }
    }
}
