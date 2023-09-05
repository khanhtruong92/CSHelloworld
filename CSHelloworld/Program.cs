using System.ComponentModel;
using System.Net.WebSockets;

namespace CSHelloworld
{
    internal class Program
    {
        //Insert the missing parts to call MyMethod two times..
        static void MyMethod()
        {
            Console.WriteLine("I just got executed 5!");
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }

    }
}