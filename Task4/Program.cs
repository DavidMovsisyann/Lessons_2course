using System;
using System.Threading;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandMet();
        }

        public static void RandMet()
        {
          Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
            Console.WriteLine(random.Next(1,100));
            Thread.Sleep(5000);

            }
        }
    }
}
