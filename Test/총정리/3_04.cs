using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    internal class _3_04
    {
        static void Main4(string[] args)
        {
            int[] values = { 3, 5, 2, 7, 1 };
            PrintArray(values);

            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
                PrintArray(values);
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine("{0,5}", i);
            }
            Console.WriteLine();
        }
    }
}
