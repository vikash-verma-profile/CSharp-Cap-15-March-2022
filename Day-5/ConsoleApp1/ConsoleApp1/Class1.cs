using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class1
    {
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public static void Main2()
        {
            /*List
           * 
           */
            Console.WriteLine("=================List============");
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);

            foreach (var item in lst)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item);
            }

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 101, Name = "Vikash 101" });
            employees.Add(new Employee() { Id = 102, Name = "Vikash 102" });
            employees.Add(new Employee() { Id = 103, Name = "Vikash 103" });

            foreach (Employee item in employees)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.Id.ToString().Length);
                Console.WriteLine(item.Id + " "+item.Name);
            }

            /*Dictionary
            * 
            * Key-Value Pair
            * 
            * x=>vikash
            */
            Console.WriteLine("=================Dictionary============");
            Dictionary<int,string> ht = new Dictionary<int,string>();
            ht.Add(1, "Oracle");
            ht.Add(2, "vb.net");
            ht.Add(3, "asp.net");

            foreach (KeyValuePair<int,string> item in ht)
            {
                Console.WriteLine(item.Key + "=====>" + item.Value);
            }
            /*Sorted List
           * 
           * This is a combination of list and Dictionary
           * 
           * x=>vikash
           */
            Console.WriteLine("=================SortedList============");
            SortedList<string,string> sl = new SortedList<string, string>();
            sl.Add("ora", "Oracle");
            sl.Add("vb", "vb.net");
            sl.Add("asp", "asp.net");
            foreach (KeyValuePair<string, string> item in sl)
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
            Stack<string> stk = new Stack<string>();
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
            Queue<string> q = new Queue<string>();
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
