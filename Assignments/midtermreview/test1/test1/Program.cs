using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aNum;
            string inputValue;

            WriteLine("Please input an integer to match with the magic number: ");
            inputValue = ReadLine();

            while(int.TryParse(inputValue, out aNum) == false || aNum != 10)
            {
                WriteLine("Invalid format, please input again with an integer");
                WriteLine("The current value of aNum is " + aNum);
                inputValue = ReadLine();
            }
            ReadKey();
        }
    }
}
