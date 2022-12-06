using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FileStream & StreamReader
            // 都可以处理大文件,几百kb的文件可以直接用File类

            // FileStream: 读取字节,可以处理所有类型文件
            // StreamReader: 读取字符, 只能处理文本文件

            // 1. 创建FileStream
            FileStream fs = new FileStream
                ("C:\\Users\\mj\\Desktop\\new.txt",FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5]; // 5M

            // 返回本次实际读取到的有效字节数
            int r = fs.Read(buffer, 0, buffer.Length);

            // 将字节数组中每一个元素按照指定的编码格式解码成字符串
            string s = Encoding.Default.GetString(buffer, 0, r);

            // 关闭流
            fs.Close();

            // 释放流所占用的资源
            fs.Dispose();

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
