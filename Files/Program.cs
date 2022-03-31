using System;
using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Uset\Desktop\test.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path,"Hello");
            }
            

        }
    }
}
