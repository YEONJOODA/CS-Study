using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    internal class _1_07
    {
        static void Main1(string[] args)
        {
            Console.Write("더하고자 하는 숫자들을 입력 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();

            foreach (string i in v)
            {
                sum += int.Parse(i);
            }

            Console.WriteLine("결과 : {0}", sum);
        }
    }
}
