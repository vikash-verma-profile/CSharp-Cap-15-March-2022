using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*
     * array
     * Structure==> hetrogeneous type of data struct
     * 
     * Fields
     * Parameterized comstructor
     * Constants
     * Properties
     * Methods
     * 
     */

    struct Student
    {
        public string Name;
        public int Age;
        public int Roll_no;
    }
    internal class Class14
    {
        public static void Main()
        {
            Student student;

            student.Name = "Vikash";
            student.Age = 30;
            student.Roll_no = 101;

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Roll_no);

        }
    }
}
