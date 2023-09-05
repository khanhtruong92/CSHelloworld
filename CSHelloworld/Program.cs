using System.ComponentModel;
using System.Net.WebSockets;

namespace CSHelloworld
{
    internal class Program
    {
        // homework 1 : Write a function to output student grade.
        static void Main(string[] args)
        {
            int mark = 80;

            if (mark > 60) 
            {
                Console.WriteLine("First Division");
            } 
            else if (mark >= 45 && mark <= 59)
            {
                Console.WriteLine("Second Division");
            } 
            else if (mark >= 33 && mark <= 44)
            {
                Console.WriteLine("Third Division");
            } 
            else
            {
                Console.WriteLine("Fail");
            }
        }

    }
}