﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrototype
{
    internal class Cclass : Mercedes
    {
        public Cclass(int price, string colour, string number, int enginevolume, int wastage,int year) : base(price, colour, number, enginevolume, wastage,year)
        {
        }
        public override void Driving()
        {
            Console.WriteLine("I'm driving mercedes C class");
        }
    }
}