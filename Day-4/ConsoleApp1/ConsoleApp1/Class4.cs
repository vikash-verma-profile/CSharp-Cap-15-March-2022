using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    abstract class AreaClass
    {
        abstract public int Area();  
    }
    class square : AreaClass
    {
        int side = 0;
        public square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }
    }
    internal class Class4
    {

        public static void Main5()
        {
            square s = new square(6);
            Console.WriteLine(s.Area());
        }
    }
}
