using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //static 
    /*
     * class
     * variables or Fields
     * Methods
     * Constructors
     */

    //static variable or field .If we use static with it,Then we don't need to create a class object .
    /*we can directly call it by using class name
     * when you are static field only once copy will be there that is going shared among all the objects 
     * that we have at class level
     */

    /*Static class
     * 
     * 1.Static class can have only static data members,static methods and static constructors
     * 2.you cannot create objects of that static class and you cannot inherit this class
     */

    /*Static Methods
     * 
     * 1.you can access static methods by using class name only without creating the object of that class
     */


    /*Static Constructor
     * 
     * 1.you can't call it directly
     * 2.when it is executing the the user has no control
     * 3.here we dont take any access modifiers or parameters
     * 4.it is called automatically to initialize the class before the first instance is created
     */

    //static class DummyStatic
    //{
    //    public static string Sample = "Static value";
    //}
    class DummyStatic
    {
        public  string Sample = "Static value";
        static DummyStatic()
        {
            Console.WriteLine("Hi I am a static constructor");
        }
        public DummyStatic()
        {
            Console.WriteLine("Hi I am a Default constructor");
        }

        public void Display()
        {    
            Console.WriteLine(Sample);
        }
    }
    public class Class1
    {
        public static void Main2()
        {
            DummyStatic s=new DummyStatic();
            s.Display();
           // Console.WriteLine(DummyStatic.Sample);
            //Convert.ToInt32(Console.ReadLine());
        }
    }
}
