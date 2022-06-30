using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    internal class _3_02
    {
        enum COLOR { red, green, blue };

        static void Main1(string[] args)
        {
            COLOR[,] colors = new COLOR[3, 3];

            colors[0, 0] = COLOR.red;
            colors[0, 1] = COLOR.red;
            colors[0, 2] = COLOR.red;

            colors[1, 0] = COLOR.green;
            colors[1, 1] = COLOR.green;
            colors[1, 2] = COLOR.green;

            colors[2, 0] = COLOR.blue;
            colors[2, 1] = COLOR.blue;
            colors[2, 2] = COLOR.blue;

            for (int i = 0; i < 3; i++)
            {
                for (int j=0; j < 3; j++)
                {
                Console.Write("{0,3}", (int)colors[i, j]);
                }
            Console.WriteLine();
            }
        
        }
    }
}
