using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyClass
    {
        public static int length = 0;
        public dynamic[] array = new dynamic[length];

        public dynamic[] AddElement(dynamic[] arr, dynamic dynm)
        {
            int length2 = length + 1;
            dynamic[] array2 = new dynamic[length2];
            for (int i = 0; i < length; i++)
            {
                array2[i] = arr[i];
            }
            array2[length2-1] = dynm;
             return array2;
        }

        public dynamic GetByIndex(int i)
        {
            return array[i];
        }

        public int GetLength()
        {
            return length;
        }
        public MyClass(int lengthh,dynamic[] array)
        {
         length = lengthh;
         this.array = array;
        }

    }
     class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            dynamic[] array = {212,"sasa",new Program() };

            MyClass myClass = new MyClass(length,array);
            dynamic[] array2 = myClass.AddElement(array,"sa");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
