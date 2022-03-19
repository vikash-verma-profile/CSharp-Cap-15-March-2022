using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*
     * 
     * strings are immutable
     */

    /*
     * two types of parameters in functions or methods
     * 1.named parameter
     * 2.Default parameter or optional parameter
     * 
     */
    internal class Class11
    {
        public static void Sample(int a,int b,int c)
        {
            Console.WriteLine("a= "+a+" b= "+b+" c= "+c);
        }
        public static void sample2(int a=1, int c=0,int b=2)
        {
            Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
        }
        public static void Main()
        {
            //string a = "1";
            //a="2";
            //Console.WriteLine(a);
            //StringBuilder b = new StringBuilder();  
            //b.Append("jhghg");
            //Sample(b:1,a:2,c:3);
            sample2();
        }

    }
}
