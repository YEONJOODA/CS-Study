using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P213
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            foreach (var item in list)
            {
                Console.WriteLine("Count: "+ list.Count + "\titem: " + item);
            }
        }
    }
}
