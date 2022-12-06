using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * 1. please create an application the name of which is your first name.
 * 
 * 2. please create a two methods Perimeter() and Area(). They are used to
 *    to calculate the perimeter and area of a rectangle. You can decide 
 *    how to pass the necessary parameters and obtain the returned values.
 */

namespace Jie
{
    internal class Program
    {

        public static double Perimeter(double width, double length)
        {
            double perimeter = 2.0 * (width + length);
            return perimeter;
        }

        public static double Area(double width, double length)
        {
            double area = width * length;
            return area;
        }


        public static double AskForLength()
        {
            Write("please input the length of rectangle: ");
            string length = ReadLine();
            return double.Parse(length);
        }
        public static double AskForWidth()
        {
            Write("please input the width of rectangle: ");
            string width = ReadLine();
            return double.Parse(width);
        }
        

        static void Main(string[] args)
        {
            double width = AskForWidth();
            double length = AskForLength();

            double perimeter = Perimeter(width, length);
            double area = Area(width, length);

            WriteLine("The perimeter is {0}.", perimeter);
            WriteLine("The area is {0:F2}.", area);

            ReadKey();

        }
    }
}
