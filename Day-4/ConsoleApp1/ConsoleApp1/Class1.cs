using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassA
    {
        int n1, n2;
        public ClassA()
        {
            Console.WriteLine("Base class Constructor is called");
        }
        public ClassA(int i,int j)
        {
            n1 = i;
            n2 = j;
            Console.WriteLine("Values are n1= "+n1+" n2= "+n2);
        }
    }
    public class DerivedClass : ClassA
    {
        public DerivedClass():base()
        {

        }
        public DerivedClass(int i,int j):base(i,j)
        {

        }
    }
    /*
     * base keyword while calling base-class constructor from dervied class 
     * when derived class instnaces are created
     */
    internal class Class1
    {
        public static void Main()
        {
            DerivedClass d1 = new DerivedClass();
            Console.WriteLine();
            DerivedClass d2 = new DerivedClass(10,20);
        }
    }
}
