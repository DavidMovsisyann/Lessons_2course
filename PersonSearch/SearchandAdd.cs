using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSearch
{
    internal class SearchandAdd : Datas
    {
        public delegate void Getstrs(string str);
        public delegate void Getints(int a);

        public void CreatePerson(int id, string name, int age, int salary, bool ismarried, string spouce, string car)
        {
            Person.Id = id;
            Person.Name = name;
            Person.Age = age;
            Person.Salary = salary;
            Person.IsMarried = ismarried;
            Person.Spouce = spouce;
            Person.Car = car;

            IdName.Add(id, name);
            IdAge.Add(id, age);
            IdSalary.Add(id, salary);
            IdCar.Add(id, car);
            IdSpouce.Add(id, spouce);
            IdIsMarried.Add(id, ismarried);

            
        }
        public void Delegates(int a,string str)
        {
            Getstrs gets = GetByName;
            gets += GetByCar;
            gets+= GetBySpouce;
           Getints getints = GetBySalary;
            getints += GetByAge;
            getints(a);
            gets(str);
        }
        public void GetByName(string name)
        {
            int key = IdName.FirstOrDefault(x => x.Value == name).Key;
            Console.WriteLine($"Id is {key}");
        }
        public void GetBySalary(int salary)
        {
            int key = IdSalary.FirstOrDefault(x => x.Value == salary).Key;
            Console.WriteLine($"Id is {key}");
        }

        public void GetByAge(int age)
        {
            int key = IdAge.FirstOrDefault(x => x.Value == age).Key;
            Console.WriteLine($"Id is {key}");
        }

        public void GetBySpouce(string spouce)
        {
            int key = IdSpouce.FirstOrDefault(x => x.Value == spouce).Key;
            Console.WriteLine($"Id is {key}");
        }

        public void GetByCar(string car)
        {
            int key = IdCar.FirstOrDefault(x => x.Value == car).Key;
            Console.WriteLine($"Id is {key}");
        }
        public void GetByMarriege(bool ismarried)
        {
            int key = IdIsMarried.FirstOrDefault(x => x.Value == ismarried).Key;
            Console.WriteLine($"Id is {key}");
        }
       
        
            
    }
}
