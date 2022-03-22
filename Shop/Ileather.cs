using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal interface Ileather
    {
        int Quality { get; set; }
        bool isChimical { get; set; }
        string Origin { get; set; }

    }
}
