using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P266
    {
        class Test
        {
            public int Power(int x)
            {
                return x * x;
            }
        }

        static void Main1(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
        }
    }
}
