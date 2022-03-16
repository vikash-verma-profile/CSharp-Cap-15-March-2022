using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //parse and TryParse
    //parse vs TryParse vs convert class
    //Nullable
    //null
    internal class Class8
    {
        public static void Main8()
        {
            int x = int.Parse("12");
            Console.WriteLine(x);
            int result;
            bool y = int.TryParse("gfdfxf", out result);
            Console.WriteLine(y);
            Console.WriteLine(result);
            //create a program if i enter a interger value it will parse and show me the parsed value
            //but if i can any string it should return message please enter input in correct format

            int? i = null;
            Nullable<int> i1 = null;
        }
    }
}
