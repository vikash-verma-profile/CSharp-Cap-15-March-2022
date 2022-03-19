using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IVehicle
    {
        void ChangeGear(int a);
        void SpeedUp(int a);
        void applyBreaks(int a);
    }
    class Bicycle : IVehicle
    {
        int speed, gear;
        public void applyBreaks(int decrement)
        {
            speed = speed - decrement;
        }

        public void ChangeGear(int newgear)
        {
            gear = newgear;
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }
        public void Print()
        {
            Console.WriteLine("Speed = " + speed + " Gear : " + gear);
        }
    }
    class Bike : IVehicle
    {
        int speed, gear;
        public void applyBreaks(int decrement)
        {
            speed = speed - decrement;
        }

        public void ChangeGear(int newgear)
        {
            gear = newgear;
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }
        public void Print()
        {
            Console.WriteLine("Speed = " + speed + " Gear : " + gear);
        }
    }
    internal class Class6
    {
        public static void Main7()
        {
            Bicycle bicycle = new Bicycle();
            bicycle.ChangeGear(2);
            bicycle.SpeedUp(3);
            bicycle.applyBreaks(1);
            bicycle.Print();
            Console.WriteLine("================================Bike=========");
            Bike bike=new Bike();
            bike.ChangeGear(3);
            bike.SpeedUp(5);
            bike.applyBreaks(3);
            bike.Print();
        }
    }
}
