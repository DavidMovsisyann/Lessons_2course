using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal interface IGender
    {
        bool isMale { get; set; }
        bool isFemale { get; set; }
        bool isChild { get; set; }
    }
}
