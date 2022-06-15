using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P302
    {
        class Program
        {
            static void Change(int input)
            {
                input = 20;
            }

            static void Main1(string[] args)
            {
                int a = 10;
                Change(a);
                Console.WriteLine(a);
            }
        }
    }
}
