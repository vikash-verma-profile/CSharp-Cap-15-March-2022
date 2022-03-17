using System;

namespace ConsoleApp1
{
    //constructors
    //public ,private,protected,internal,internal protected,private internal

    class Sample
    {
        int x, y;
        //Private constructor
        //private Sample()
        //{

        //}
        //Default constructor
        //public Sample()
        //{

        //}
        //Parameterized constructor
        public Sample()
        {
            x = y = 0;
        }
        public Sample(int a,int b)
        {
            x =a;
            y = b;
        }

    }
    class Vehicle
    {
        //Fields
        private string name;
        private string color;
        private int quantity;

        //copy constructor
        public Vehicle(Vehicle _v)
        {
            name = _v.name;
            color = _v.color;   
            quantity = _v.quantity; 
        }
        //Parameterized Constructors
        public Vehicle(string _name,string _color,int _qunatity)
        {
            name = _name;
            color = _color;
            quantity = _qunatity;
        }

        //Get details or Vehicle
        public void PrintVehicleDetails()
        {
            Console.WriteLine("Type :"+name.ToString()+"\n color: "+color.ToString()+"\n Quantity: "+quantity.ToString());
        }
    }

    internal class Program
    {
        //<access-modifier> <Class-Name> (<parameters>)

        /*
         * 1.Default constructor
         * 2.Static constructor
         * 3.Private constructor
         * 4.Copy constructor
         * 5.Parameterized constructor
         */

        //default constructor
        static void Main(string[] args)
        {
            // Sample s=new Sample(1,2);
            Vehicle v1 = new Vehicle("Bike","Black",40);
            Vehicle v2 = new Vehicle(v1);

            
           v2.PrintVehicleDetails();
        }
    }
}
