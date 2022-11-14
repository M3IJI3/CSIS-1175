using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] anArray = { { 34,55,67,89,99 },
                               { 22,68,11,19,45 } };

            // 行
            Console.WriteLine(anArray.GetLength(0));
            // 列
            Console.WriteLine(anArray.GetLength(1));
            // dimension
            Console.WriteLine(anArray.Rank);
            // column * row
            Console.WriteLine(anArray.Length);


            Console.WriteLine(anArray[0, anArray.GetLength(0) - 2]);
            Console.WriteLine(anArray[0, 3] * anArray[0, 0]);
        }
    }
}

