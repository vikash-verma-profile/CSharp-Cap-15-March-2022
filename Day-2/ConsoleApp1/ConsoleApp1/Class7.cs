using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //var and dynamic
    internal class Class7
    {
        public static void Main()
        {
            //var its a compiler time
            /*
            var i = 1;// as a integer value
            Console.WriteLine(i.GetType());
            var i1 = "1";
            Console.WriteLine(i1.GetType());
            var point = 1.56;
            Console.WriteLine(point.GetType());
            //i = "Csharp";//string 
            Console.WriteLine(i);
            */
            //dynamic is working at run time 
            //automatic typecasting is happening

            dynamic sample = 1;
            Console.WriteLine(sample.GetType());
            sample = "Csharp";
            Console.WriteLine(sample.GetType());
            Console.WriteLine(sample);
        }
    }
}
