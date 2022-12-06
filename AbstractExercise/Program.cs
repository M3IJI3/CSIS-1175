using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle    = new Circle(3);
            Console.WriteLine(circle.Perimeter());
            Console.WriteLine(circle.Area());

            Shape rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(rectangle.Area());
            
            Console.ReadKey();
        } 
    }

    public abstract class Shape
    {
        public abstract double Perimeter();

        public abstract double Area();
    }

    class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }

    class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


        public override double Area()
        {
            return Height * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}

