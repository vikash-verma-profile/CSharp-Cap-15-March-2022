using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //IS vs AS
    /*
     * IS will be used to impose some check
     * 
     * AS will be used to do the typecast
     */

    class p
    {

    }
    class p1:p
    {

    }
    class p3
    {

    }
    internal class Class9
    {
        public static void Main10()
        {
            p obj=new p();
            p1 obj1=new p1();

            Console.WriteLine(obj is p);//true
            Console.WriteLine(obj1 is object);//true
            Console.WriteLine(obj is p1);   //false
            Console.WriteLine(obj1 is p1);   //true

            Console.WriteLine("===================================================");

            object[] o=new object[5];
            o[0] = new p();
            o[1] = new p1();
            o[2] = "Hello";
            o[3] = 4.67;
            o[4] = null;

            for (int i = 0; i < o.Length; i++)
            {
                string str = o[i] as string;
                if (str != null)
                {
                    Console.WriteLine(str); 
                }
                else
                {
                    Console.WriteLine("Is not a string");
                }
            }
        }
    }
}
