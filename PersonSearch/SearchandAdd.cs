using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSearch
{
    internal class SearchandAdd : Datas
    {

        public void CreatePerson(int id, string name, int age, int salary, bool ismarried, string spouce, string car)
        {
            Person.Id = id;
            Person.Name = name;
            Person.Age = age;
            Person.Salary = salary;
            Person.IsMarried = ismarried;
            Person.Spouce = spouce;
            Person.Car = car;

            NameId.Add(id,name);
            AgeId.Add(age, id);
            SalaryId.Add(salary, id);
            CarId.Add(car, id);
            SpouceId.Add(spouce, id);
            IsMarriedId.Add(ismarried, id);
        }
        public void GetByName(string name)
        {
            int key = NameId.FirstOrDefault(x => x.Value == name).Key;
            Console.WriteLine(NameId[key]);
        }
        public void GetBySalary(int salary)
        {
            int key = NameId.FirstOrDefault(x => x.Value == salary).Key;

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
