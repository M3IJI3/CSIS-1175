using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DirectoryStructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // . means the current directory
            DirectoryInfo dir = new DirectoryInfo(".");
            WriteLine("Current diectory is " + Directory.GetCurrentDirectory());

            // *.* refers to anythings
            foreach(FileInfo fil in dir.GetFiles("*.*"))
            {
                string filename = fil.Name;
                long size = fil.Length;
                DateTime creationTime = fil.CreationTime;
                WriteLine("{0,35} {1,12:N0} {2,20:G}",
                    filename, size, creationTime);
            }

            ReadKey();
        }
    }
}
