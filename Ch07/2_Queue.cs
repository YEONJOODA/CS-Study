using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/15
 * 이름 : 김연주
 * 내용 : 컬렉션 큐 실습
 */
namespace Ch07
{
    internal class _2_Queue
    {
        static void Main1(string[] args)
        {
            Queue<string> que = new Queue<string>();

            que.Enqueue("1");
            que.Enqueue("2");
            que.Enqueue("3");
            que.Enqueue("4");
            que.Enqueue("5");

            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
