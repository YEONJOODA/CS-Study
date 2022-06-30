using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    internal class _2_09
    {
        static void Main9(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                    Console.Write("☆");

                for (int k = 0; k <= i; k++)
                    Console.Write("★");

                Console.Write("\n");
            }
            Console.WriteLine();

            for (int i = 1; i < 5; i++)
            {
                for (int j = 4; j > i; j--)
                    Console.Write("☆");

                for (int k = 0; k < i * 2 - 1; k++)
                    Console.Write("★");

                for (int j = 4; j > i; j--)
                    Console.Write("☆");

                Console.Write("\n");
            }
            Console.WriteLine();
        }
    }
}
