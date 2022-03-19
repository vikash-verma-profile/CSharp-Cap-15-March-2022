using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    /*Boxing and Unboxing
     * Boxing=>value type to refernce type conversion
     * UnBoxing=>refernce type to value type  conversion
     */
    internal class Class8
    {
        public static void Main9()
        {
            int a = 6;
            object b = 5;

            //boxing
            b= a;
            Console.WriteLine("After Boxing  "+b);
            //UNBOXING
            b = 10;
            a = (int)b;
            Console.WriteLine("After UnBoxing  "+b);
        }
    }
}
