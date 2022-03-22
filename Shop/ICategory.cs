using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal interface ICategory
    {
        bool isSport { get; set; }
        bool isClassic { get; set; }
        bool isTraditional { get; set; }

    }
}
