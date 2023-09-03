using System.Collections.Generic;
using System.Reflection;

namespace CSHelloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print "Hello World" if x is greater than y.
            int x = 50;
            int y = 10;
            if (x > y)
{
                Console.WriteLine("Hello World");
            }

            //Print "Hello World" if x is equal to y.
            int a = 50;
            int b = 50;
            if (a == b)
{
                Console.WriteLine("Hello World");
            }

            //Insert the missing parts to complete the following "short hand if...else statement"(ternary operator):
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}