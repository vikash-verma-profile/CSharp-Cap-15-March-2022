using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Overriding

    //virtual and ovveride

    public class baseClass
    {
        public  virtual void show()
        {
            Console.WriteLine("I am in base class");
        }
    }
    public class derivedClass:baseClass
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("I am in derived class");
        }

    }
    internal class Class9
    {
        public static void Main()
        {
            baseClass obj;
            obj = new baseClass();
            //obj.show();//I am in base class
            obj = new derivedClass();
            obj.show();//I am in derived class
        }
    }
}
