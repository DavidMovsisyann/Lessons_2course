using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        public A() { Console.WriteLine("A"); }
    }
    class B :A
    {
        public B()
        {
            Console.WriteLine("B");
        }
    }
    class C :B
    {
        public C()
        {
            Console.WriteLine("C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            Console.ReadLine();
        }
    }
}
