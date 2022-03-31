using System;
using System.IO;
namespace StreamWriters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(docpath, "test.txt")))
            {
                streamWriter.WriteLine("Hello");
            }
        }

    }
}
