using System;

namespace Lesson2_OOP
{
    interface IDisel 
    {
    
    }

    interface IPetrol 
    {
    
    }
   public class Car
    {
        public int year;
    }
    class Mercedes : Car
    {
        protected int speed;
        public int SpeedCalc()
        {
            if (year >= 2007)
            {
                speed = 260;
            }
            else { speed = 180; }
            return speed;
        }
    }
    class ML_Class:Mercedes,IDisel
    {
        public void Drive()
        {
            Console.WriteLine("You are driving");
            Console.WriteLine($"Your speed is {SpeedCalc()}");
        }
    }

    class C_Class:Mercedes ,IPetrol
    {
        public void Drive()
        {
            Console.WriteLine("You are driving");
            Console.WriteLine($"Your speed is {SpeedCalc()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Car car = new Car();
            car.year = 2009;
            ML_Class ml = new ML_Class();
            ml.Drive();
        }
       
    }
}
