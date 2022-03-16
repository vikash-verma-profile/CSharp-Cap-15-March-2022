using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class1
    {
        static int sum_user(int a, int b)
        {
            return (a + b);
        }
        static int sub_user(int a, int b)
        {
            return (a - b);
        }
        static int mul_user(int a, int b)
        {
            return (a * b);
        }
        static int div_user(int a, int b)
        {
            return (a / b);
        }
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a and b ");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            bool flag=true;
            while (flag)
            {
                Console.WriteLine("Enter options \n 1. Add \n 2. Subract \n 3. Multiply \n 4. Divide \n 5.Exit");
                int userinput = Int32.Parse(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        Console.WriteLine("Sum of " + a + " and " + b + " is " + sum_user(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Subract of " + a + " and " + b + " is " + sub_user(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Product of " + a + " and " + b + " is " + mul_user(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Divition of " + a + " and " + b + " is " + div_user(a, b));
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
          
        }
    }
}

