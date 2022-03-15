using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class4
    {
        //Switch
        public static void Main()
        {
            int choice=3;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Case O is called");
                    break;
                case 1:
                    Console.WriteLine("Case 1 is called");
                    break;
                default:
                    Console.WriteLine("default block is called");
                    break;
            }
        }
    }
}
