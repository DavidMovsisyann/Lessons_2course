using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSearch
{
    internal class SearchandAdd : Datas
    {

        public void AddPerson(int id, string name, int age, int salary, bool ismarried, string spouce, string car)
        {
          CreatePerson(id,name,age,salary,ismarried,spouce,car);
        }
        public void GetByName(string name)
        {
            
            Console.WriteLine(NameId[name]);
        }
        public void GetBySalary(int salary)
        {
            Console.WriteLine(SalaryId[salary]);
        }

        public void GetByAge(int age)
        {
            Console.WriteLine(AgeId[age]);
        }

        public void GetBySpouce(string spouce)
        {
            Console.WriteLine(SpouceId[spouce]);
        }

        public void GetByCar(string car)
        {
            Console.WriteLine(CarId[car]);
        }
        public void GetByMarriege(bool ismarried)
        {
            Console.WriteLine(IsMarriedId[ismarried]);
        }
    }
}
