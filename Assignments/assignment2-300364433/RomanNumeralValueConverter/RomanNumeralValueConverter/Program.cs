using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace RomanNumeralValueConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {     

            int input = 1;
            Test t = new Test();

            while(input != 0)
            {
                Write("Roman-Decimal Converter\n" + 
                      "1. Input a test value\n" +
                      "0. Quit\n");
                Write("Options: ");

                try
                {
                    input = int.Parse(ReadLine());

                    switch (input)
                    {
                        case 1:
                            WriteLine("The result is -> {0}\n",
                                RomanDecimalConverter(t.InputTestValue()));
                            break;
                        case 0:
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    WriteLine("The input option is not valid!\n");
                }
                
            }
        }

        public static string RomanDecimalConverter(int value)
        {
            string[] romanValue = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
            string result;

            if (errorCheck(value))
                result = romanValue[value - 1];
            else
                result = "Input value is not in the range of 1~10";

            return result;
        }

        public static Boolean errorCheck(int value)
        {
            Boolean flag;

            if (value < 1 || value > 10)
                flag = false;
            else
                flag = true;

            return flag;
        }      
    }
}
