using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DelegateExample
{
    delegate int Transformer(int x);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Transformer t = new Transformer(Square);
            // 简写
            Transformer t = Square; // create delegate instance

            // int result = t.Invoke(3);
            int result = t(3); // Invoke delegate

            WriteLine(result);

            ReadKey();

        }

        static int Square(int x) => x * x;
    }
}
