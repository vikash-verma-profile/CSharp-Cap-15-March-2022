using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //overload a operator

    class Calculator
    {
        public int number1,number2;
        public Calculator()
        {

        }
        public Calculator(int num1,int num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            Calculator c3 = new Calculator();
            c3.number1 = c1.number1 + c2.number1;
            c3.number2 = c1.number2 + c2.number1;
            return c3;
        }
        public void Print()
        {
            Console.WriteLine("number1 :" + number1 +" number2 :"+number2);
        }
    }
    internal class Class8
    {
        public static void Main9()
        {
            Calculator c1 = new Calculator(15,15);
            Calculator c2 = new Calculator(30,30);
            Calculator c3 = new Calculator();
            c3 = c1 + c2;
            c3.Print();
        }
    }
}
