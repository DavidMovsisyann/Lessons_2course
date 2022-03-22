//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Task1
//{
//    class MyClass
//    {
//        public dynamic[] array = {1221,"SASA",'s' };

//        public void AddElement(dynamic dynm)
//        {
//            int length2 = array.Length + 1;
//            dynamic[] array2 = new dynamic[length2];
//            for (int i = 0; i < array.Length; i++)
//            {
//                array2[i] = array[i];
//            }
//            array2[length2-1] = dynm;

//        }

//        public dynamic GetByIndex(int i)
//        {
//            return array[i];
//        }
//        public dynamic Remove(dynamic[] arr, dynamic dynm)
//        {

//            return null;
//        }

//        public int GetLength()
//        {
//            return array.Length;
//        }
        

//    }
//     class Program
//    {
//        static void Main(string[] args)
//        {
            
//         MyClass myClass = new MyClass();
//            myClass.AddElement('1');
//            foreach (var item in myClass.array)
//            {
//                Console.WriteLine(item);
//            }
//            Console.ReadLine();
//        }
//    }
//}
