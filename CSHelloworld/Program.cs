using System.Net.WebSockets;

namespace CSHelloworld
{
    internal class Program
    {
        // This is a single-line comment
        /* This is a multi-line comment */

        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x - y;
        }


        static void Main(string[] args)
        {
            //var test2 = new MyMethod();
            //test2.Name = "Test";
            //test2.test();
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

        }
    }
}