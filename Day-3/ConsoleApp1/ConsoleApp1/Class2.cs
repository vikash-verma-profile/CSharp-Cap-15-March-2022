using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Inheritance
    //Parent class or base class
    //single level inheritance
    class BaseClass
    {
        protected internal int a;
        public void Print()
        {
            Console.WriteLine(a);
            Console.WriteLine("I am a Method in parent class");
        }
    }
    //Child class or Derived class
    class ChildClass: BaseClass
    {
        public void Display()
        {
            Console.WriteLine(a);
            Console.WriteLine("I am a Method in child class");
        }
    }
    class ChildClass2 : ChildClass
    {

    }
    internal class Class2
    {
        public static void Main3()
        {
           ChildClass c=new ChildClass();
            BaseClass b = new BaseClass();
            //b.
            //c.Display();
            //c.Print();
        }
    }
}
