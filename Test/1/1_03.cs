using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _1_03
    {
        static void Main1(string[] args)
        {
            int x = 4;
            int y = -2;
            int z;

            z = x + y;
            Console.WriteLine("x + y = " + z);

            z = x - y;
            Console.WriteLine("x - y = " + z);

            z = x * y;
            Console.WriteLine("x * y = " + z);

            z = x / y;
            Console.WriteLine("x / y = " + z);

            z = (x + y) * (x - y);
            Console.WriteLine("(x + y) * (x - y) = " + z);
        }
    }
}
