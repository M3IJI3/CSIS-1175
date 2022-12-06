using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> lastinFirstOut = new Stack<string>();

            lastinFirstOut.Push("Jill Won");
            lastinFirstOut.Push("Donna Abbott");
            lastinFirstOut.Push("Jeremy Door");
            lastinFirstOut.Push("Oliver Rivers"); 
            lastinFirstOut.Pop();
            DisplayInfo(lastinFirstOut);

            ReadKey();

        }

        public static void DisplayInfo(Stack<string> lastInFirstOut)
        {
            WriteLine("Stack - Last In First Out ");
            WriteLine("\nNumber of Elements: {0}", lastInFirstOut.Count);
            Write("Values:");
            foreach(var item in lastInFirstOut)
            {
                Write("\t{0}", item);
            }
            WriteLine();
        }
    }
}
