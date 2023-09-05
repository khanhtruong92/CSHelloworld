using System.ComponentModel;
using System.Net.WebSockets;
using System.Xml.Linq;

namespace CSHelloworld
{
    internal class Program
    {
        // Insert the missing part to print the number 8 in Main, by using a specific keyword inside MyMethod:
        static int MyMethod(int x)
        {
            return 5 + x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
        }

    }
}