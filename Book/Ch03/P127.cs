using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P127
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }
            if(input % 2 == 1)
            {
                Console.WriteLine("홀수입니다!");
            }
        }
    }
}
