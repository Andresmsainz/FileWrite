using System;
using System.IO;

namespace FileWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FileWrite!");

            string file = @"C:\temp\names.txt";
            StreamWriter sw = new StreamWriter(file,true);

            sw.WriteLine("Starsky");
            sw.WriteLine("Hutch");
            sw.Close();

        }
    }
}
