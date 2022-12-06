using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 先将需要复制的多媒体文件读取出来，再放到一个新的位置
            string source = @"C:\Users\mj\Desktop\Ideas_Overflow.pdf";
            string target = @"C:\Users\mj\Desktop\new.pdf";
            CopyFile(source, target);
            Console.WriteLine("Succeed!");
            Console.ReadKey();
        }

        public static void CopyFile(string source, string target)
        {
            using(FileStream fsread = new FileStream(source,FileMode.Open,FileAccess.Read))
            {
                // 创建一个负责写入的流
                using(FileStream fswrite = new FileStream(target,FileMode.OpenOrCreate,FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    
                    // 因为文件可能会比较大, 所以在读取的时候应该通过一个循环去读取
                    // 返回本次读到的字节数
                    
                    while(true)
                    {
                        int r = fsread.Read(buffer, 0, buffer.Length);

                        // 如果返回一个0, 也就读取完了
                        if(r == 0)
                        {
                            break;
                        }

                        fswrite.Write(buffer, 0, r);
                    }
                   
                }
            }
        }
    }
}
