using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_2course
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = { 11,323,45,32,3444,0 };

            ////Bubble Sort 

            //int temp = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length -1; j++)
            //    {
            //        if (arr[j] > arr[j+1] )
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            //Selection Sort

            //int temp2 = 0;
            //int min;

            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    min = i;
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[j]<arr[min])
            //        {
            //            min = j;
            //        }
            //    }
            //        temp2 = arr[min];
            //        arr[min] = arr[i];
            //        arr[i] = temp2;


            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Insertation Sort

            //int temp;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    temp = arr[i];
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (arr[j-1] > arr[j])
            //        {
            //            temp = arr[j - 1];
            //            arr[j-1] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
            
        }
    }
}
