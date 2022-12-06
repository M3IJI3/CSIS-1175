using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SomeDelegatesExample
{
    delegate int Transformer(int x);

    internal class Program
    {
        static void Main(string[] args)
        {
            Transformer t = null;

            // 如果多播委托的返回类型不是void
            // 那么调用者会从最后一个被调用的方法来接受返回值
            // 前面的方法仍然会被调用, 但是前面方法的返回值会被弃用
            t += Cube;
            t += Square;

            t -= Square;

            int result = t.Invoke(3);

            ReadKey();
        }

        static int Cube(int x)
        {
            int result = x * x * x;
            WriteLine(result);
            return result;
        }

        static int Square(int x)
        {
            int result = x * x;
            WriteLine(result);
            return result;
        }
    }
}
