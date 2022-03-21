using System;
using System.Collections;

namespace ConsoleApp1
{
    /* Collections
     * 
     * Adding and inserting of items or data
     * removing items 
     * Finding sorting and searching
     * Replacing items
     * 
     * Non-Generic    Generic
     * 
     * ArrayList=====>LIST
     * HashTable=====>Dictionary
     * SortedList====>SortedList
     * Stack=========>Stack
     * Queue=========>Queue
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            /*ArrayList
             * 
             */
            Console.WriteLine("=================ArrayList============");
            ArrayList al = new ArrayList();
            string str = "Vikash";
            int x = 7;
            DateTime dt = DateTime.Now;
            al.Add(x);
            al.Add(str);
            al.Add((DateTime)dt);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }


            /*HashTable
            * 
            * Key-Value Pair
            * 
            * x=>vikash
            */
            Console.WriteLine("=================Hashtable============");
            Hashtable ht=new Hashtable();
            ht.Add("ora","Oracle");
            ht.Add("vb", "vb.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"=====>"+item.Value);
            }
            /*Sorted List
           * 
           * This is a combination of arraylist and hashtable
           * 
           * x=>vikash
           */
            Console.WriteLine("=================SortedList============");
            SortedList sl = new SortedList();
            sl.Add("ora", "Oracle");
            sl.Add("vb", "vb.net");
            sl.Add("asp", "asp.net");
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "=====>" + item.Value);
            }

            /*
             * Stack
             * 
             * LIFO
             * 
             */
            Console.WriteLine("=================Stack============");
            Stack stk = new Stack();
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("Oracle");
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }


            /*
             * Queue
             * 
             * FIFO
             * 
             */
            Console.WriteLine("=================Queue============");
            Queue q = new Queue();
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("Oracle");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
