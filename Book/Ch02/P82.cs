using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P82
    {
        static void Main1(string[] args)
        {
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a + b);
           
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);
        }
    }
}
