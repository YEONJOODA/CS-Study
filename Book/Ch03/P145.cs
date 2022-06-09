using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P145
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("입력: ");
            string line = Console.ReadLine();

            if(line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
            }
            else
            {
                Console.WriteLine("^^");
            }
        }
    }
}
