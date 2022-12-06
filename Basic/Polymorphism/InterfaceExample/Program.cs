using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public interface IFlyable
    {
        // 接口中的成员不允许添加访问修饰符, 默认就是public
        // * 类里面不添加访问修饰符, 默认就是private
        void Fly();
        string Test();
        // 不允许写具有方法体的函数
    }
}
