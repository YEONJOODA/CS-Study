using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P168
    {
        static void Main1(string[] args)
        {
            int output = 1;

            for (int i = 1; i <= 20; i++)
            {
                output *= i;
            }
            Console.WriteLine(output);

            for (int i = '가'; i <= '힣'; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
