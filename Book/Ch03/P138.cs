using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P138
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());

            switch(input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break ;
            }
        }
    }
}
