using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    class Member
    {
        public string Name { get; init; }
        public string Hp { get; init; }
        public int Age { get; init; }

        public override string ToString()
        {
            return $"{Name}, {Hp}, {Age}";
        }
    }

    internal class _4_08
    {
        static void Main8(string[] args)
        {
            // 초기화 프로퍼티를 이용한 객체 생성
            Member m1 = new Member { Name = "김유신", Hp = "010-1234-1001", Age = 25 };
            Member m2 = new Member { Name = "김춘추", Hp = "010-1234-1002", Age = 23 };
            Member m3 = new Member { Name = "장보고", Hp = "010-1234-1003", Age = 37 };

            // 무명형식 객체
            var m4 = new { Name = "강감찬", Hp = "010-1234-1004", Age = 41 };
            var m5 = new { Name = "이순신", Hp = "010-1234-1005", Age = 52 };

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);
        }
    }
}
