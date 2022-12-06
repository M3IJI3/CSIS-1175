using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DelegateExample1
{
    delegate int Transformer(int x);

    class Util
    { 
        public static void Transform(int[] values, Transformer t)
        {
            for(int i = 0; i< values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = {1, 2, 3 };
            Util.Transform(values, Square);

            foreach(int i in values)
            {
                WriteLine(i);
            }

            ReadKey();
        }

        static int Square(int x) => x * x;
    }
}
