using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using static System.Console;

namespace PrintShape
{
    internal class Shape
    {
        public int eachSideNumOfAsterisks;

        public Shape()
        {
           
        }

        public Shape(int eachSideNumOfAsterisks)
        {
            this.eachSideNumOfAsterisks = eachSideNumOfAsterisks;
        }

        public void DisplayShape()
        {
            Shape shape = new Shape(4);
            shape.Enlarge();
        }

        public void Enlarge()
        {
            int eachSideNumOfDots = 0;
            string temp;

            Stack<string> stack  = new Stack<string>();

            while (eachSideNumOfAsterisks >= 0)
            {
                temp = "".PadLeft(eachSideNumOfDots, '.') + "".PadLeft(eachSideNumOfAsterisks, '*') + "*" + "".PadRight(eachSideNumOfAsterisks, '*') + "".PadRight(eachSideNumOfDots, '.');
                stack.Push(temp);
                eachSideNumOfAsterisks--;
                eachSideNumOfDots++;
            }

            foreach (string s in stack)
            {
                WriteLine(s);
            }
        }
    }

    
}
