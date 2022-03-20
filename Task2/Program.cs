using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    interface IProfilactic
    {

    }
    class Person : University
    {
        string FirstName;
        string LastName;
        string FatherName;
        char Gender;
        int Age;
        string LivingPlace;

        public Person(string FirstName, string LastName, string FatherName, char Gender, int Age, string LivingPlace)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FatherName = FatherName;
            this.Gender = Gender;
            this.Age = Age;
            this.LivingPlace = LivingPlace;
        }
    }

    class University
    {

    }

    class Faculty : University
    {
        class HeadofFaculty : Person
        {
            public HeadofFaculty(string FirstName, string LastName, string FatherName, char Gender, int Age, string LivingPlace) : base(FirstName, LastName, FatherName, Gender, Age, LivingPlace)
            {
            }
        }
        class StaticDepartament
        {

        }

        public class StudentGroup
        {
            public class Student : Person
            {
                public class Parents : Person
                {
                    public Parents(string FirstName, string LastName, string FatherName, char Gender, int Age, string LivingPlace) : base(FirstName, LastName, FatherName, Gender, Age, LivingPlace)
                    {
                    }
                }
                public bool hasParent = true;
                public StudentGroup studentGroup = new StudentGroup();
                public Student(string FirstName, string LastName, string FatherName, char Gender, int Age, string LivingPlace, bool hasParent) : base(FirstName, LastName, FatherName, Gender, Age, LivingPlace)
                {
                    this.hasParent = hasParent;
                    studentGroup = studentGroup;
                }
            }
            class Teacher : Person
            {
                string Subject;
                StaticDepartament staticDepartament = new StaticDepartament();
                public Teacher(string FirstName, string LastName, string FatherName, char Gender, int Age, string LivingPlace, string Subject) : base(FirstName, LastName, FatherName, Gender, Age, LivingPlace)
                {
                    this.Subject = Subject;
                    staticDepartament = staticDepartament;
                }
            }
            class ProfilacticDepartament : IProfilactic
            {

            }
            class HeadManStudent : Student
            {
                public HeadManStudent(string FirstName, string LastName, string FatherName, char Gender, int Age, string LivingPlace, bool hasParent) : base(FirstName, LastName, FatherName, Gender, Age, LivingPlace, hasParent)
                {
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Jack";
            string LastName = "Black";
            string FatherName = "Tom";
            char Gender = 'm';
            int Age = 50;
            string LivingPlace = "USA";
            bool hasParent = true;
            Student student = new Student(FirstName, LastName, FatherName, Gender, Age, LivingPlace, hasParent);
        }
    }
}
