using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P99
    {
        static void Main1(string[] args)
        {
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265L).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());
        }
    }
}
