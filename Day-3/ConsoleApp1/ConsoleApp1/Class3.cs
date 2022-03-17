using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    /// <summary>
    /// <access modifiers> <return tye> <property-name>{  get {//body }  set {//body}}
    /// </summary>
    class C1
    {
        //abstraction
        //public int rn;
        //public string name;
        private int roll_no=101;

        public int Roll_no
        {
            get
            {
                return roll_no;
            }
            set
            {
                roll_no = value;
            }
        }
        public void Print()
        {
            Console.WriteLine(roll_no);
        }


    }
    internal class Class3
    {
        //properties
        

        /*
         * 
         */
        public static void Main()
        {

            C1 c1 = new C1();
            c1.Roll_no = 102;
            c1.Print();
        }
    }
}
