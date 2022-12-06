using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralValueConverter
{
    internal class Test
    {
        public int InputTestValue()
        {
            Console.Write("Input a decimal number: ");
            int temp = int.Parse(Console.ReadLine());
            return temp;
        }
    }
}
