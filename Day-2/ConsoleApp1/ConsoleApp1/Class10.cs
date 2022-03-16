using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ManyObjects
{
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
        public static Employee[] DeleteEmployee(Employee [] _employeeList,int _empId)
        {
            Employee[] employeeList=new Employee[2];
            int index = 0;
            for (int i = 0; i < _employeeList.Length; i++)
            {
                if (_employeeList[i] != null)
                {
                    if (_empId != _employeeList[i].employeeiD)
                    {
                        employeeList[index] = _employeeList[i];
                        index++;
                    }
                }
            }
            return employeeList;
        }
    }
    internal class Class10
    {
        public static void Main()
        {
            Employee[] employeeList = new Employee[2];
            int index = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter options \n 1. Create \n 2. List \n 3. Delete \n 5.Exit");
                int userinput = Int32.Parse(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        Employee employee = new Employee();
                        employee.GetData();
                        employeeList[index] = employee;
                        index++;
                        break;
                    case 2:
                        for (int i = 0; i < employeeList.Length; i++)
                        {
                            if (employeeList[i] != null)
                            {
                                employeeList[i].DisplayEmployee();
                            }
                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please enter EmployeeID for employee you want to remove");
                        int _employeeId = Convert.ToInt32(Console.ReadLine());
                        employeeList=Employee.DeleteEmployee(employeeList, _employeeId);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

          
           
            //for (int i = 0; i < employeeList.Length; i++)
            //{
            //    Employee employee = new Employee();
            //    employee.GetData();
            //    employeeList[index] = employee;
            //    index++;
            //}
            //for (int i = 0; i < employeeList.Length; i++)
            //{
            //    employeeList[i].DisplayEmployee();
            //}
        }
    }
}
