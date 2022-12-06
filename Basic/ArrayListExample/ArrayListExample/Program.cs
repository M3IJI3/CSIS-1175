using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList anArray = new ArrayList();

            anArray.Add("Today is the first day of the " +  
                        "rest of your life!");
            anArray.Add(2);
            anArray.Add("Live it to the fullest!");
            anArray.Add(34.89);
            anArray.Add("ok");
            anArray.Add("You may not get a second chance.");

            WriteLine("Count of elements in array: {0}", anArray.Count);

            anArray.RemoveAt(4);
            WriteLine("New Count (after removing ok): {0}", anArray.Count);
            WriteLine();
            DisplayContents(anArray);

            ReadKey();
        }

        public static void DisplayContents(ArrayList ar)
        {
            for(int i = 0; i < ar.Count; i++)
            {
                WriteLine(ar[i]);

                if(i == 1)
                {
                    WriteLine((int)ar[i] * 100);
                }
            }
            WriteLine();
        }
    }
}
