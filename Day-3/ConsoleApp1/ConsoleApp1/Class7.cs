using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Method Overloading
    //1.it very in the number of parameter we have in a function
    //2.It very in the type of parameter that we have in a function
    internal class Class7
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sum()
        {
            int a=1,b=0;
            Console.WriteLine(a + b);
        }
        public void Sum(string a,string b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }

        public static void Main8()
        {
            Class7 class7 = new Class7();
            class7.Sum();
            class7.Sum(1, 2);
            class7.Sum(1, 2,3);
            class7.Sum("Hi","and Hello");
        }
    }
}
