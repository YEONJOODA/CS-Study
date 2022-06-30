using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    internal class _4_06
    {
        static void Main6(string[] args)
        {
            var p1 = ("김유신", "010-1234-1001", 25);
            var p2 = ("김춘추", "010-1234-1002", 23);
            var p3 = (name: "장보고", hp: "010-1234-1003", age: 33);
            var p4 = (name: "강감찬", hp: "010-1234-1004", age: 41);
            var (name, hp, age) = ("이순신", "010-1234-1005", 52);

            Console.WriteLine($"{p1.Item1}, {p1.Item2}, {p1.Item3}");
            Console.WriteLine($"{p2.Item1}, {p2.Item2}, {p2.Item3}");
            Console.WriteLine($"{p3.name}, {p3.hp}, {p3.age}");
            Console.WriteLine($"{p4.name}, {p4.hp}, {p4.age}");
            Console.WriteLine($"{name}, {hp}, {age}");
        }
    }
}
