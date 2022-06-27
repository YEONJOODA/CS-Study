using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    internal class _1_06
    {
        static void Main6(string[] args)
        {
            string s = " Hello, World! ";

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);
            Console.WriteLine(s.Insert(8, "C# "));
            Console.WriteLine(s.PadLeft(20, '.'));
            Console.WriteLine(s.PadRight(20, '.'));
            Console.WriteLine(s.Remove(6));
            Console.WriteLine(s.Remove(6, 7));
            Console.WriteLine(s.Replace('l', 'm'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');

            Console.WriteLine(s.Substring(8));
            Console.WriteLine(s.Substring(8, 5));

            Console.WriteLine(string.Concat("Hi~", s));

            string[] val = { "apple", "orange", "grape" };
            string result = string.Join(", ", val);
            Console.WriteLine(result);
        }
    }
}
