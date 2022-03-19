using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class Person
	{
		public string name;
		public override string ToString()
		{
			return "Hello my name is " + name;
		}
	}
	internal class Class2
    {
		public static void Main()
		{
			Person[] p1 = new Person[3];
		
			for (int i = 0; i < p1.Length; i++)
			{
				Console.WriteLine("Enter name:");

				p1[i] = new Person { name = Console.ReadLine() };

				//Person p=new Person();
				//p.name=Console.ReadLine();
				//p1[i] = p;
			}
            for (int i = 0; i < p1.Length; i++)
            {
				Console.WriteLine(p1[i].ToString());
            }
		}
	}
}
