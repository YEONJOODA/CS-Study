using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
    internal class _5_04
    {
        static void Main1(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                SortedSet<int> set = new SortedSet<int>();
                
                foreach(int n in set)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

        public static SortedSet<int> MakeLotto()
        {
            SortedSet<int> set = new SortedSet<int>();
            Random random = new Random();

            for ( ; ; )
            {
                int num = random.Next(1, 46);

                set.Add(num);

                if (set.Count == 6)
                {
                    break;
                }
            }

            return set;
        }
    }
}
