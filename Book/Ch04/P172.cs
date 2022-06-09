using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P172
    {
        static void Main1(string[] args)
        {
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
