using System;

namespace ConsoleApp1
{
    class web
    {
        string name = "Base Keyword";
        public virtual void Show()
        {
            Console.WriteLine(name);    
        }
    }
    class Stream : web
    {
        string subject = "C sharp";
        public override void Show()
        {
            base.Show();
            Console.WriteLine(subject);
        }
    }
    internal class Program
    {

        /*base keyword
        1.if you want to call methods or function from derived class
        2.call constructors internally of base class at the time of inheritence
        */
        static void Main1(string[] args)
        {
            Stream stream = new Stream();
            stream.Show();
            Console.WriteLine("Hello World!");
        }
    }
}
