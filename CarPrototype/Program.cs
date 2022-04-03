using System;

namespace CarPrototype
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Cclass cclass = new Cclass(12000,"yellow","36pp032",3,7,2008);
            Console.WriteLine(cclass.Year);
        }
    }
}
