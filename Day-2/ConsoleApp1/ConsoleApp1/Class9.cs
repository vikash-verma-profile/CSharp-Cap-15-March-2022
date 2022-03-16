using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public int ID;
        //Fields
        //Properties
        //Constructors
        //Destructors
        //Methods
        //Indexers
    }

    class Employee
    {
        public int employeeiD;
        public string employeename;
        public string employeeGender;
        public double employeeSalary;
    }
    internal class Class9
    {
        public static void Main()
        {
            //<class-Name> objectname=new <class-Name>()
            //Student student = new Student();
            //student.ID = 101;
            //Console.WriteLine(student.ID);
            /*create a program of employee where employee can have
            employeeiD
            employeename
            employeeGender
            employeeSalary
            */

            //taking input from user
            Employee emp=new Employee();
            Console.WriteLine("Please enter employee Details");
            Console.WriteLine("Please enter employee Id");
            emp.employeeiD=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter employee Name");
            emp.employeename=Console.ReadLine();
            Console.WriteLine("Please enter employee Gender");
            emp.employeeGender=Console.ReadLine();
            Console.WriteLine("Please enter employee Salary");
            emp.employeeSalary=Convert.ToDouble(Console.ReadLine());

            //print data recived from user

            Console.WriteLine("Employee Details entered by User is");

            Console.WriteLine("employee Id:" + emp.employeeiD);
            Console.WriteLine("employee Name:" + emp.employeename);
            Console.WriteLine("employee Gender:" + emp.employeeGender);
            Console.WriteLine("employee Salary:" + emp.employeeSalary);

            //for student
            //student roll number
            //student name
            //student gender
            //student class

        }
    }
}
