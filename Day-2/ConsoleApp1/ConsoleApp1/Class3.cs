using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class3
    {
        //call by value
        //call by reference ref
        public static void swap(ref int a,ref int b)
        {
            int c;
            c = b;
            b = a;
            a = c;
            Console.WriteLine("a= "+a+" b= "+b);
        }
        public static void Main3(string[] args)
        {
            int a=1, b=2;
            Console.WriteLine("value in Main before calling swap function a= " + a + " b= " + b);
            swap(ref a,ref b);
            Console.WriteLine("value in Main after calling swap function a= " + a + " b= " + b);
        }
    }
}
