using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2
{
    internal class _2_09
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("3! = "+ factorial(3));
            Console.WriteLine("3! = "+ factorial(4));
            Console.WriteLine("3! = "+ factorial(5));
        }

        public static int factorial(int n)
        {
            if(n <= 1)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }
    }
}
