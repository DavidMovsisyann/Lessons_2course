using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Shoes : Market, Ileather, IGender, ICategory
    {
        public Shoes(int price, string name, string barCode) : base(price, name, barCode)
        {
        }

        public bool isMale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isFemale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isChild { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isChimical { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Origin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isSport { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isClassic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isTraditional { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
