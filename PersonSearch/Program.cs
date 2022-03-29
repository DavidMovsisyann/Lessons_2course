using System;
using System.Collections.Generic;
namespace PersonSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SearchandAdd search = new SearchandAdd();
            search.CreatePerson(1, "Jack", 20, 500, false, "", "90oo077");
            search.GetBySalary(500);
           
        }
    }
}
