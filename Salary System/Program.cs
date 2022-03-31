using System;

namespace Salary_System
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int salary = int.Parse(Console.ReadLine());
            Salary.IncomeTaxRef(ref salary);
            Salary.SocialFeeRef(ref salary);
            Salary.IncomeTaxOut(out salary,salary); 
            Salary.SocialFeeOut(out salary,salary);
          
            
        }
    }
    static class Salary
    {
        public static void IncomeTaxRef(ref int salary)
        {
            int tax_precent = salary * 15 / 100;
            salary -= tax_precent;    
        }

        public static void SocialFeeRef(ref int salary)
        {
            int fee = salary * 3/100 ;
            salary -= fee;
        }
        public static void IncomeTaxOut(out int salary,int money)
        {
            salary = money;
            salary =  salary * 15 / 100;
        }

        public static void SocialFeeOut(out int salary,int money )
        {
            salary = money;
            salary -= salary * 3 / 100;;
        }
      
    }
}
