using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSearch
{
    public class Datas
    {
       public Dictionary<int,string> NameId = new Dictionary<int, string>();
       public Dictionary<int, int> IdAge = new Dictionary<int, int>();
       public Dictionary<int, int> SalaryId = new Dictionary<int, int>();
       public Dictionary<bool, int> IsMarriedId = new Dictionary<bool, int>();
       public Dictionary<string,int> SpouceId = new Dictionary<string,int>();
       public Dictionary<string,int> CarId = new Dictionary<string,int>();
    }
}
