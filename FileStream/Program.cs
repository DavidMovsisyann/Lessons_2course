using System;
using System.IO;
namespace StreamWriters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\test.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("hello");
            streamWriter.Close();
        }
    }
}
