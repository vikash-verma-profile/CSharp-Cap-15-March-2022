using System;

namespace ConsoleApp1
{
    /*Functions
     * <Return-Type> function name (<function parameters>){
     * <body>
     * }
     * 
     */
    internal class Program
    {

        static int Sum(int a,int b)
        {
            return (a + b);
            //Console.WriteLine("Sum is "+sum);
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sum = Sum(1,2);
            Console.WriteLine("Sum is " + sum);
        }

    }

    //create a program for calculator user will give choice 1,2,3,4
    //ask user his choice then ask for 2 numbers to perform the operation
    //1==>sum
    //2=>sub 3=>mul 4=>divide
}
