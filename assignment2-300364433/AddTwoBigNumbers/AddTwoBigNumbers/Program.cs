using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AddTwoBigNumbers
{
    internal class Program
    {
        public const int SIZE = 100;

        static void Main(string[] args)
        {
            string s1 = "6754356756348786543256456789876545324156453466787654565545676543122234567890987654321234567898765432";
            string s2 = "9235467908767890987234567098765234567898765213456909876756453253467898764562156789345678909817265431";
            // WriteLine(AddTwoBigIntegers(s1, s2));
            WriteLine("#1 number: {0}", s1);
            WriteLine("#2 number: {0}", s2);
            WriteLine("\n\n\nCalculations: \n");

            WriteLine("\t{0}\n + \t{1}", s1, s2);
            WriteLine("".PadLeft(SIZE + 8, '-'));
            WriteLine("       {0}", AddTwoBigIntegers(s1, s2));

            ReadKey();
        }

        public static string AddTwoBigIntegers(string s1, string s2)
        {
            // the length of big integer numbers are fixed (100 digits)
            // define two char arrays to store two strings' characters
            char[] c1 = new char[SIZE];
            char[] c2 = new char[SIZE];

            c1 = s1.ToCharArray();
            c2 = s2.ToCharArray();

            // convert char arrays to int arrays
            int[] num1 = new int[SIZE];
            int[] num2 = new int[SIZE];

            for(int i = 0; i < SIZE; i++)
            {
                num1[i] = (int)char.GetNumericValue(c1[i]);
                num2[i] = (int)char.GetNumericValue(c2[i]);
            }

            // store the carry
            int carry = 0;

            // define an array to store each number of result on every digits
            // the largest digits number of result is 101. 
            int[] result = new int[SIZE];

            for (int i = SIZE - 1; i >= 0; i--)
            {
                int sum = num1[i] + num2[i] + carry;
                result[i] = sum % 10;
                carry = sum / 10;
  
                if (i == 0)
                {
                    result[i] = sum;
                }
            }

            string s = "";

            for (int i = 0; i < result.Length; i++)
            {
                s += result[i];
            }
            return s;
        }
    }
}
