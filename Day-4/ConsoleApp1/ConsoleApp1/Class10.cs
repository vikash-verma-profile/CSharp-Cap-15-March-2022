using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// equal vs ==
    /// </summary>
    /// 
    /*(==) is a comparision operator==>Compares the refrence identity 
     * (Equals()) method that compares the content of a strin==> compares only the content
     * 
     */
    internal class Class10
    {
        public static void Main()
        {
            string name = "Vikash";
            string myname = name;
            Console.WriteLine(myname==name);
            Console.WriteLine(myname.Equals(name));


            Console.WriteLine("==========================");
            object oname = "Vikash";
            char[] chars = { 'V', 'i', 'k', 'a', 's', 'h' };
            object omyname=new string(chars);

            Console.WriteLine(omyname == oname);//false
            Console.WriteLine(oname.Equals(omyname));//true
        }
    }
}
