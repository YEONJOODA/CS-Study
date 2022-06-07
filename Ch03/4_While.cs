using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/07
 * 이름 : 김연주
 * 내용 : 반복문 while 실습하기 교재 p162
 */
namespace Ch03
{
    internal class _4_While
    {
        static void Main(string[] args)
        {
            // 1부터 10까지 합

            int sum = 0;
            int k = 1;

            while (k <= 10)
            {
                sum += k;
                k++;
            }

            Console.WriteLine("1부터 10까지 합 : "+sum);

            // do ~ while : 최초 1번은 무조건 반복 실행하는 반복문
            int total = 0;
            int i = 1;

            do
            {
                if(i % 2 == 0)
                {
                    total += i;
                }
                i++;
            }
            while (i <= 10);

            Console.WriteLine("1부터 10까지 짝수합 : "+total);

            //break
            int num = 1;

            while (true)
            {

                if(num % 5 == 0 && num % 7 == 0)
                {
                    break; // 반복문 종료
                }

                num++;

            }

            Console.WriteLine("5와 7의 최소공배수 : "+num);

            // continue
            int tot = 0;
            int j = 0;

            while(j <= 10)
            {
                j++;

                if(j % 2 == 1)
                {
                    continue; // 반복문의 처음으로 이동
                }

                tot += j;
            }

            Console.WriteLine("1부터 10까지 짝수합 : "+tot);






        }
    }
}
