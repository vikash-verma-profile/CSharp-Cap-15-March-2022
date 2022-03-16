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
        int employeeiD;
        string employeename;
        string employeeGender;
        double employeeSalary;
        public void GetData()
        {
            Console.WriteLine("Please enter employee Details");
            Console.WriteLine("Please enter employee Id");
            employeeiD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter employee Name");
            employeename = Console.ReadLine();
            Console.WriteLine("Please enter employee Gender");
            employeeGender = Console.ReadLine();
            Console.WriteLine("Please enter employee Salary");
            employeeSalary = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Details entered by User is");
            Console.WriteLine("employee Id:" + employeeiD);
            Console.WriteLine("employee Name:" + employeename);
            Console.WriteLine("employee Gender:" + employeeGender);
            Console.WriteLine("employee Salary:" + employeeSalary);
        }
    }
    internal class Class9
    {
        public static void Main9()
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
            emp.GetData();
            emp.DisplayEmployee();

            //print data recived from user



            //for student
            //student roll number
            //student name
            //student gender
            //student class

            Employee[] employeeList = new Employee[2];

            //create a program to store multiple employee data -2 employees
            //ask choice of user what he want to do 1.create 2.list employees 3.delete employee 4.exit

        }
    }
}
