using System;

namespace ConsoleApp1
{
    public class Person
    {
        protected int _age;
        public void Greet()
        {
            Console.WriteLine("Hello....");
        }
        public void SetAge(int age)
        {
            _age = age;
        }
    }
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + _age.ToString() + " years old .....");
        }
    }
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I am Explaining");
        }
    }
    public class Class5
    {
        public static void Main()
        {
            Person pp = new Person();
            pp.Greet();

            int s_age, t_age;
            Student ss = new Student();
            Console.WriteLine("Please provide the age of the student:");
            s_age = Convert.ToInt32(Console.ReadLine());
            ss.SetAge(s_age);
            ss.Greet();
            ss.ShowAge();

            Teacher tt = new Teacher();
            Console.WriteLine("Please provide the age of the Teacher:");
            t_age = Convert.ToInt32(Console.ReadLine());
            tt.SetAge(t_age);
            tt.Greet();
            tt.Explain();
        }
    }
}