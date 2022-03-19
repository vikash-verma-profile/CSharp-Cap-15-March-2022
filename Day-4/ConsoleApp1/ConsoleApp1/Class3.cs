using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    /*
     * Abstract class
     * 1.You can not create an object of this class
     * 2.if you use abstract with a method then you cannot define that method in base class
     * 3.Derived class must provide the implementation of the method that is being marked as abstract 
     *   in base class by using keyword override
     */

    abstract class A
    {
        public void sample()
        {
            Console.WriteLine("Hello");
        }
        public abstract void Show();//only signature no body can be there for an abstarct method
    }
    class ClassB:A
    {
        public override void Show()
        {
            Console.Write("Hello");
        }
    }
    internal class Class3
    {
        public static void Main4()
        {
            ClassB b=new ClassB();
            b.sample();
        }
    }
}
