using System.ComponentModel;
using System.Net.WebSockets;
using System.Xml.Linq;

namespace CSHelloworld
{
    internal class Program
    {
        // Add a fname parameter of type string to MyMethod.
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
        }

    }
}