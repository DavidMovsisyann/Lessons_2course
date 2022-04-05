using System;

namespace Currency_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculating calculating = new Calculating();
            calculating.DramStatistics(1);
        }
    }
   public class Datas
    {
        protected int Dolar { get; set; } = 483;
        protected int Rubli { get; set; } = 6;
        protected int Euro { get; set; } = 535;
        protected int Funt { get; set; } = 640;
    }
    public class Calculating:Datas
    {
        
        public delegate void CalculatingDelegate(int count);
        public event CalculatingDelegate CalculatingEvent;

        public void DramStatistics(int count)
        {
            CalculatingEvent = CalculateFromDolar;
            CalculatingEvent += CalculateFromEuro;
            CalculatingEvent += CalculateFromRubli;
            CalculatingEvent += CalculateFromFunt;
            CalculatingEvent(count);
        }
        private void CalculateFromDolar(int count)
        {
            Console.WriteLine($"{count} dolars are {count*Dolar} drams");
            
        }
        private void CalculateFromRubli(int count)
        {
            Console.WriteLine($"{count} rublis are {count * Rubli} drams");
        }
        private void CalculateFromEuro(int count)
        {
            Console.WriteLine($"{count} euros are {count * Euro} drams");
        }
        private void CalculateFromFunt(int count)
        {
            Console.WriteLine($"{count} funts are {count * Funt} drams");
        }
        
    }
}
