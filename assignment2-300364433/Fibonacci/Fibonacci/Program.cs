using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Fibonacci
{
    internal class Program
    {
        const int FIBONACCI_SIZE = 200;

        static void Main(string[] args)
        {
            string[] fibonacci = new string[FIBONACCI_SIZE];
           // Random rd = new Random();

            fibonacci[0] = "0";
            fibonacci[1] = "1";

            for (int i = 2; i < FIBONACCI_SIZE; i++)
            {
                string s = AddTwoBigIntegers(fibonacci[i - 2], fibonacci[i - 1]);
                fibonacci[i] = s;

            }

            for (int i = 0; i < FIBONACCI_SIZE; i++)
            {
                //Thread.Sleep(rd.Next(0,200));
                WriteLine("{0}-->{1}",i+1, fibonacci[i]);
            }

            ReadKey();

        }

        public static string AddTwoBigIntegers(string s1, string s2)
        {
           

            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            int[] num1 = new int[s1.Length];
            int[] num2 = new int[s2.Length];

            for(int i = 0; i < num1.Length; i++)
            {
                num1[i] = (int)char.GetNumericValue(c1[i]);
            }

            for(int i = 0; i < num2.Length; i++)
            {
                num2[i] = (int)char.GetNumericValue(c2[i]);
            }

            int carry = 0;
            Stack<int> result = new Stack<int>();

            if(s1.Length - s2.Length == 0)
            {
                for(int i = s1.Length - 1; i >= 0; i--)
                {
                    int sum = num1[i] + num2[i] + carry;

                    result.Push(sum % 10);
                    carry = sum / 10;

                    if(i == 0 && carry > 0)
                    {
                        result.Push(carry);
                    }
                    
                }             
            }
            else
            {
                for(int i = 1; i <= s2.Length; i++)
                {
                    if(s1.Length - i >= 0)
                    {
                        int sum = num1[s1.Length - i] + num2[s2.Length - i] + carry;
                        result.Push(sum % 10);
                        carry = sum / 10;
                    }
                    else
                    {
                        int sum = num2[s2.Length - i] + carry;
                        result.Push(sum % 10);
                        carry = sum / 10;

                        if (s2.Length - i == 0 && carry > 0)
                        {
                            result.Push(carry);
                        }
                    }                   
                }
            }

            string s3 = "";

            foreach (int item in result)
            {
                s3 += item;
            }

            return s3;
        }
       
    }
}
