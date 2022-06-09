using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P93
    {
        static void Main1(string[] args)
        {
            int number = 10;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);

            
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);

            
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(--number);
            Console.WriteLine(number);


        }
    }
}
