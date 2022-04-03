using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrototype
{
    internal class Car
    {
        public int Price { get; set; }
        public string Colour { get; set; }
        public string Number { get; set; }
        public int EngineVolume { get; set; }
        public int Wastage { get; set; }
        public int Year { get; set; }
        public virtual void Driving()
        {
            Console.WriteLine("I'm driving");
        }
        public Car(int price, string colour, string number, int enginevolume, int wastage,int year)
        {
            Price = price;
            Colour = colour;
            Number = number;
            EngineVolume = enginevolume;
            Wastage = wastage;
            Year = year;
        }

        public Car(int price, string colour, string number, int enginevolume, int wastage)
        {
            Price = price;
            Colour = colour;
            Number = number;
            EngineVolume = enginevolume;
            Wastage = wastage;
        }
    }
}
