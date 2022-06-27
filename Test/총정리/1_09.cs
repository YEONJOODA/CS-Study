using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    enum Size { Short, Tall, Grande, Venti };
    enum Coffee { Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800 };

    internal class _1_09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("커피 가격표");

            for (int i = 0; i < 4; i++)
            {
                if (i == (int)Size.Short)
                {
                    Console.WriteLine("{0,10} : {1:C}", Size.Short, Convert.ToInt32(Coffee.Short));
                }
                else if (i == (int)Size.Tall)
                {
                    Console.WriteLine("{0,10} : {1:C}", Size.Tall, Convert.ToInt32(Coffee.Tall));
                }
                else if (i == (int)Size.Grande)
                {
                    Console.WriteLine("{0,10} : {1:C}", Size.Grande, Convert.ToInt32(Coffee.Grande));
                }
                else if (i == (int)Size.Venti)
                {
                    Console.WriteLine("{0,10} : {1:C}", Size.Venti, Convert.ToInt32(Coffee.Venti));
                }
            }
        }
    }
}
