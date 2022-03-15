using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class4
    {
        //Switch
        //iteration statements
        //looping statements
        /*
         * 1.for loop
         * 2.while loop
         * 3.do while
         * 4.for each
         */
        public static void Main()
        {
            int choice=3;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Case O is called");
                    break;
                case 1:
                    Console.WriteLine("Case 1 is called");
                    break;
                default:
                    Console.WriteLine("default block is called");
                    break;
            }

            /*
             * for loop 
             * for(<intialization>;expression;increment/decrement){
             * 
             * 
             */

            //Console.Write("\n");  === Console.WriteLine();
            Console.WriteLine("====================For Loop===================");
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(" row= "+row + " col= "+col);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            /*
             * while loop Entry control loop
             * <intialization>;
             * while(expression){
             * increment/decrement;
             * }
             * 
             * do while loop  exit control loop
             * <intialization>;
             * do{
             * increment/decrement;
             * }while(expression);
             * 
             */
            Console.WriteLine("====================while Loop===================");
            int j = 0;
            while (j < 5)
            {
                Console.Write(j + "\t");
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("====================do while Loop===================");
            int k = 0;
            do
            {
                Console.Write(k + "\t");
                k++;
            } while (k <5);

        }
    }
}
