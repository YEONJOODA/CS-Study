using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _1_04
    {
        static void Main1(string[] args)
        {
            int num = 1;
            int result;

            result = num++;
            Console.WriteLine("result : " + result);

            result = ++num;
            Console.WriteLine("result : " + result);

            result = num--;
            Console.WriteLine("result : " + result);

            result = --num;
            Console.WriteLine("result : " + result);
        }
    }
}
