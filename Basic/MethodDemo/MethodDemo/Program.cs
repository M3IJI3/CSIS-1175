using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace MethodDemo
{
    internal class Program
    {
        public static int MySquare(int num)
        {
            int a = 10;
            return num * num;
        }

        public static int MySquare(double num)
        {
            WriteLine("double MySquare");
            return 1;
        }

        public static void DummyMethod(ref double num)
        {
            num = 10 * num;
            WriteLine("num is " + num);
        }

        public static double MyAdd(int num1, double num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            // a+b = b+a
            int a = 11;
            double b = 10.5;
            WriteLine("the square of {0} is {1}", a, MySquare(a));
            WriteLine("the square of {0} is {1}", a, MySquare(b));
            WriteLine("the add of {0} and {1} is {2}", a, b, MyAdd(a,b));
            WriteLine();

            WriteLine("before method invoike, b is "+b);

            DummyMethod(ref b);

            WriteLine("before method invoike, b is " + b);

            ReadKey();
        }
    }
}
