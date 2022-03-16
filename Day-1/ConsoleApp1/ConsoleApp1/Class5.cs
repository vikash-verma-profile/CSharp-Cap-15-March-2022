using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class5
    {
        public static void Main()
        {
            int num1;
            Console.WriteLine("Please enter the value of Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= num1 - i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= num1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
