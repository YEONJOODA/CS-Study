using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P214
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            list.Remove(52);

            foreach (var item in list)
            {
                Console.WriteLine("Count: "+ list.Count + "\titem: " + item);
            }
        }
    }
}
