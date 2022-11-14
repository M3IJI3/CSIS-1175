﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace PrintShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            int eachSideOfAsterisks = 4;

            while(input != 0)
            {
                WriteLine("Shape Printer\n" +
                     "1. Display the basic shape.\n" +
                     "2. Enlarge the enlarged shape.\n" +
                     "0. Quit");
                Write("Your Option: ");
                input = int.Parse(ReadLine());

                if (input == 1)
                {
                    Shape basicShape = new Shape();
                    basicShape.DisplayShape();
                }
                else if(input == 2)
                {
                    Shape enlargeShape = new Shape(eachSideOfAsterisks += 2);
                    enlargeShape.Enlarge();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
