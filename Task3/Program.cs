using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyClass<T>
    {
       
        public T[] arr = new T[0];

        public void Add(T obj)
        {
            T[] array2 = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                array2[i] = arr[i];
            }
            array2[arr.Length] = obj;
            arr = array2;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> myClass = new MyClass<string>();
            myClass.Add("Hello");
            foreach (var item in myClass.arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
