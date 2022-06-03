using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._01단계
{
    internal class Main_08
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            double n1 = int.Parse(num[0]);
            double n2 = int.Parse(num[1]);

            Console.WriteLine(n1 / n2);

        }
    }
}
