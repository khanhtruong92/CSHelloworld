using System;
using System.ComponentModel;
using System.Net.WebSockets;

namespace CSHelloworld
{
    internal class Program
    {
        // homework 3: ax^2 + bx + c = 0; Write a function to find x from Quadratic equation
        static void findX(double a, double b, double c)
        {
            double delta = (b * b) - 4 * a * c;
            if (delta < 0) 
            {
                Console.WriteLine("Vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Co 1 nghiem: " + x);
            }
            else 
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Co 2 nghiem la: " + x1 + " va " + x2);
            }
            
        }
        static void Main(string[] args)
        {
            findX(1, -4, 4);
        }

    }
}