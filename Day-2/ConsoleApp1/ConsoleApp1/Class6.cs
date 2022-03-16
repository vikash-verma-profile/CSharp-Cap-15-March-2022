using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class6
    {
        //out keyword in parameter
        //out vs ref
        public static void Main6()
        {
            int result,result2, a=1, b=2;
            //you have to define the value before passing to a function when using ref keyword
            sumOut(1, 2, out result,out result2);
            sumRef(ref a, ref b);
            Console.WriteLine("Sum by using Out :-"+result);
        }
        public static void sumOut(int a,int b,out int c,out int d)
        {
            //you have to define the value before returning from a function when you are using out keyword 
            c=a + b;
            d = 1;        
        }
        public static void sumRef(ref int a, ref int b)
        {
            int c = a + b;
            Console.WriteLine("Sum by using Ref :-"+c);
        }
    }
}
