using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2
{
    internal class _2_10
    {
        static void Main1(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write(fibo(i) + " ");
            }
        }

        public static int fibo(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return fibo(n - 1) + fibo(n - 2);
        }
    }
}
