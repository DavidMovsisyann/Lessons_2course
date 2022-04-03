using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = 0;
            int volume = 0;
            GetArea(ref area,side);
            GetVolume(ref volume, area, height);
        }

        public static void GetArea(ref int area,int side)
        {
        area = side * side; 
        }

        public static void GetVolume(ref int volume,int area,int height)
        {
            volume = area * height;
        }
    }
}
