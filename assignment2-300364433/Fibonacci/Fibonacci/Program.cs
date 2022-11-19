using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms in the fibonacci sequence : ");
            int len = Convert.ToInt32(Console.ReadLine());
            Fibonacci_Recursive(len);
        }

        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }
        private static void Fibonacci_Rec_Temp(ulong a, ulong b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.WriteLine("{0}==>{1}",counter, a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }
    }
}
