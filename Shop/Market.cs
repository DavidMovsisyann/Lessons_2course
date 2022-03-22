using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Market
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }

        public Market(int price,string name,string barCode)
        {
            price = Price;
            name = Name;
            barCode = BarCode;
        }


    }
}
