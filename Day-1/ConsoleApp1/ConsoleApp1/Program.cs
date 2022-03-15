using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Arithmatic Operators========");
            Console.WriteLine(2+3);
            Console.WriteLine(2-3);
            Console.WriteLine(2*3);
            Console.WriteLine(6/3);
            Console.WriteLine(6%3);
            //comparasion operators
            Console.WriteLine("===========Comparasion Operators========");
            //== equal
            //> ,< >=,<=
            Console.WriteLine(6==3);
            Console.WriteLine(6>3);
            Console.WriteLine(6<3);
            //logical operators

            //1.AND && (Exp 1) && (EXp 2)
            //(true) && (true)==>true
            //(true) && (false)==>false
            //(false) && (true)==>false
            //(false) && (false)==>false


            //2.OR || (Exp 1) || (EXp 2)
            //(true) || (true)==>true
            //(true) || (false)==>true
            //(false)|| (true)==>true
            //(false) || (false)==>false
            //3.NOT !
            //!(EXP1)
            //!(true)==>false
            //!(false)==>true
            Console.WriteLine("===========Logical Operators========");
            Console.WriteLine((6==3)&&(6==5));
        }
    }
}
