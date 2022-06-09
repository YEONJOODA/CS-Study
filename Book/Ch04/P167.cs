using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P167
    {
        static void Main1(string[] args)
        {
            int output = 0;
            
            for(int i = 0; i <= 100; i++)
            {
                output += i;
            }

            Console.WriteLine(output);
        }
    }
}
