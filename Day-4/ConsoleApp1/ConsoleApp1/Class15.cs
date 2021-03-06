using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Exceptions
    /*
     * try==> used to defind a try block and that will hold the code that may throw an exception
     * catch==.This block will catch the exception that is being thrown by the try block
     * finally 
     * throw
     * Custom exception
     */
    internal class Class15
    {
        public static void Main16()
        {
            try
            {
                int a = 0, b = 7;
               // int c = b / a;
                //Console.WriteLine(c);
                int []a1=new int[2];
                a1[0] = 1;
                Console.WriteLine(a1[0]);
                throw new Exception("Hi i am a manual exception");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Some exception have occured");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("I am your finally block");
            }
           
        }
    }
}
