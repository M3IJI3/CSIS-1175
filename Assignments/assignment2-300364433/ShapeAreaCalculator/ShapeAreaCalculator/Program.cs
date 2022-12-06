using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            int input = 1;
            double radius, width, length, height;
            
            while(input != 0)
            {
                WriteLine("Shape Area Calculator\n" +
                      "1. Circle\n" +
                      "2. Rectangle\n" +
                      "3. Cylinder\n" +
                      "0. Quit");
                Write("Options: ");

                input = int.Parse(ReadLine());

                switch(input)
                {
                    case 1:
                        Write("Input circle radius: ");
                        radius = double.Parse(ReadLine());
                        WriteLine("The area of circle is: {0:F2}\n", AreaOfCircle(radius));
                        break;
                    case 2:
                        Write("Input rectangle width: ");
                        width = double.Parse(ReadLine());
                        Write("Input rectangle length: ");
                        length = double.Parse(ReadLine());
                        WriteLine("The area of rectangle is: {0:F2}\n", AreaOfReatangle(width, length));
                        break;
                    case 3:
                        Write("Input cylinder radius: ");
                        radius = double.Parse(ReadLine());
                        Write("Input cylinder height: ");
                        height = double.Parse(ReadLine());
                        WriteLine("The area of cylinder is: {0:F2}\n", AreaOfCylinder(radius, height));
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
               
            }
            
        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public static double AreaOfReatangle(double width, double length)
        {
            double area = width * length;
            return area;
        }

        public static double AreaOfCylinder(double radius, double height)
        {
            double area = 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
