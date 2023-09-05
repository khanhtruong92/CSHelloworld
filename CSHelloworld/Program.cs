using System.ComponentModel;
using System.Net.WebSockets;

namespace CSHelloworld
{
    internal class Program
    {
        //Create a method named MyMethod and call it inside Main().
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}