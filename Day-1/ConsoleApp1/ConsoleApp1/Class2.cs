using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main2(string[] args)
        {
            //<data-type> <variable-name>
            //Comments
            // single line comment
            /*
             
            
            Multi line comment
             */
            /*
            int number=1,Numebr2=6;
            string SampleName="Sample";
            Console.WriteLine(SampleName);
            Console.WriteLine(number+ Numebr2);

            Console.WriteLine("Please enter some value");
            //Taking Input from user
            string s=Console.ReadLine();

            //printing the input we recive from user
            Console.WriteLine(s);

            //Convert class
            int Number1;
            Console.WriteLine("Please enter Number1 value");
            Number1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Number1);
            */
            int Number1,Number2,Sum;
            Console.WriteLine("Please enter the value of Number 1");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of Number 2");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Sum = Number1 + Number2;
            Console.WriteLine("Sum of 2 numbers is "+ Sum);
            //do all the arithmetic operations
        }
    }
}
