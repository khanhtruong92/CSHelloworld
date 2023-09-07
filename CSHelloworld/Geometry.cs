using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHelloworld
{
    internal class Geometry
    {
        protected double width;
        protected double height;
        public Geometry(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }

    class Triangle : Geometry
    {
        public Triangle(double width, double height) : base(width, height) { }

        public void area()
        {
            double area = width * height * 0.5;
            Console.WriteLine("Area of Triangle: " + area);
        }
    }

    class Rectangle : Geometry
    {
        public Rectangle(double width, double height) : base(width, height) { }
        public void area()
        {
            double area = width * height;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(10, 5);
            Rectangle rectangle = new Rectangle(10, 5);
            triangle.area();
            rectangle.area();

        }
    }
}
