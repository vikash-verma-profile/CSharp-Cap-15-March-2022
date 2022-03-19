using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    /*
     * write custom exception
     */

    class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.WriteLine("Exception have occured");
        }
    }
    internal class Class16
    {
        public double DivisonOperation(double numerator,double denominator)
        {
            if (denominator ==0)
            {
                throw new DivByZero();
            }
            return numerator / denominator;
        }
        public static void Main()
        {
            Class16 sample= new Class16();
            double numerator = 9, denominator =0 ;
            try
            {
                Console.WriteLine(sample.DivisonOperation(numerator, denominator));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
