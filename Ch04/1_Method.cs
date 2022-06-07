using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/07
 * 이름 : 김연주
 * 내용 : 메서드 실습하기 교재 p265
 */
namespace Ch04
{
    internal class _1_Method
    {
        static void Main1(string[] args)
        {
            // 메서드 호출
            int r1 = f(1);

            int r2 = f(2);

            int r3 = f(3);


            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);

            // 메서드 호출
            int t1 = Sum(1, 10);
            int t2 = Sum(1, 100);
            int t3 = Sum(start:1, end:1000);

            Console.WriteLine("t1 : "+t1);
            Console.WriteLine("t2 : "+t2);
            Console.WriteLine("t3 : "+t3);

        }// Main end

        // 메서드 정의
        public static int f(int x)
        {
            int y = 2 * x + 3;
            return y; 
        }

        // 메서드 정의
        public static int Sum(int start, int end)
        {
            int total = 0;

            for (int k = start; k <= end; k++)
            {
                total += k;
            }

            return total;
        }
    }
}
