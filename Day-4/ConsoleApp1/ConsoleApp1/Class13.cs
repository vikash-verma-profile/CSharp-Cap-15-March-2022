using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Parameter
    {
        public enum shapes
        {
            circle,
            square
        }

        public void peri(int val ,shapes s1)
        {
            if (s1 == 0)
            {
                Console.WriteLine(2*3.14*val);
            }
            else{
                Console.WriteLine(4 * val);
            }
        }
    }
    internal class Class13
    {
        public static void Main()
        {
            Parameter a1=new Parameter();
            a1.peri(3,Parameter.shapes.circle);
            a1.peri(4, Parameter.shapes.square);
        }
    }
}
