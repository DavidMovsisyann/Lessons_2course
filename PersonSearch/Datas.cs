using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSearch
{
    public class Datas
    {
       public Dictionary<string,int> NameId = new Dictionary<string,int>();
       public Dictionary<int, int> AgeId = new Dictionary<int, int>();
       public Dictionary<int, int> SalaryId = new Dictionary<int, int>();
       public Dictionary<bool, int> IsMarriedId = new Dictionary<bool, int>();
       public Dictionary<string,int> SpouceId = new Dictionary<string,int>();
       public Dictionary<string,int> CarId = new Dictionary<string,int>();

        public void CreatePerson(int id,string name,int age,int salary,bool ismarried,string spouce,string car)
        {
            Person.Id = id;
            Person.Name = name;
            Person.Age = age;
            Person.Salary = salary;
            Person.IsMarried = ismarried;
            Person.Spouce = spouce;
            Person.Car = car;

            NameId.Add(name,id); 
            AgeId.Add(age,id);
            SalaryId.Add(salary,id);    
            CarId.Add(car,id);
            SpouceId.Add(spouce,id);
            IsMarriedId.Add(ismarried,id);
        }
    }
}
