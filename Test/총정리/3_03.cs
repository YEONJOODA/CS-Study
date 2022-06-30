using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    internal class _3_03
    {
        static void Main3(string[] args)
        {
            Random random = new Random();
            int[] values = new int[30];

            for (int i = 0; i < 30; i++)
                values[i] = random.Next(1000);

            PrintArray("정렬 전", values);

            Array.Sort(values);
            PrintArray("정렬 후", values);

            Console.Write("=> 검색할 숫자 입력 : ");
            int findNum = int.Parse(Console.ReadLine());
            int count = 0;

            // 선형탐색
            for (int i = 0; i < values.Length - 1; i++)
            {
                count++;
                if (values[i] == findNum)
                {
                    Console.WriteLine("values[{0}] = {1}", i, findNum);
                    Console.WriteLine("선형탐색 비교 횟수 {0}회", count);
                    break;
                }
            }

            // 이진탐색
            count = 0;
            int low = 0;
            int high = values.Length - 1;

            while (low <= high)
            {
                count++;
                int mid = (low + high) / 2;

                if (findNum == values[mid])
                {
                    Console.WriteLine("values[{0}] = {1}", mid, findNum);
                    Console.WriteLine("이진탐색 비교 횟수 {0}회", count);
                    break;
                }
                else if (findNum > values[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
        }

        public static void PrintArray(string tit, int[] array)
        {
            Console.WriteLine(tit);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,5}{1}", array[i], (i % 10 == 9) ? "\n" : "");
            }
        }
    }
}
