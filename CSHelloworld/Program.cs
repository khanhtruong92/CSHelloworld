using System;
using System.ComponentModel;
using System.Net.WebSockets;

namespace CSHelloworld
{
    internal class Program
    {
        // homework 2: ax + b = 0 Write a function to find x from Linear equation.
        static double findX(double a, double b)
        {
            return -b / a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(findX(2, 3)); // -1.5: because 2x + 3 = 0 => x = -1.5;
        }

    }
}