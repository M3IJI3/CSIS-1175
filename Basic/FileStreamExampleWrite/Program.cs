using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExampleWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用FileStream来写入数据
            using(FileStream fswrite = new FileStream("C:\\Users\\mj\\Desktop\\new.txt",FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "im going to rewrite this file.";
                byte[] buffer = Encoding.Default.GetBytes(str);
                fswrite.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
