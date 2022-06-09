using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P92
    {
        static void Main1(string[] args)
        {
            string output = "hello";
            output += "world";
            output += "!";

            Console.WriteLine(output);

            
            output = output + "world";
            output = output + "!";

            Console.WriteLine(output);

        }
    }
}
