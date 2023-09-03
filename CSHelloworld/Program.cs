using System.Collections.Generic;
using System.Reflection;

namespace CSHelloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print i as long as i is less than 6.
            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }

            // Use the do/while loop to print i as long as i is less than 6.
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 6);
        }

    }
}