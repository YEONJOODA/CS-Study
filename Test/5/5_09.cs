using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
    class MyStack
    {
        const int maxSize = 10;
        private int[] arr = new int[maxSize];
        private int top;

        public MyStack()
        {
            top = 0;
        }

        public void Push(int val)
        {
            if (top < maxSize)
            {
                arr[top] = val;
                ++top;
            }
            else
            {
                Console.WriteLine("Stack Full!");
                return;
            }
        }

        public int Pop()
        {
            if (top > 0)
            {
                --top;
                return arr[top];
            }
            else
            {
                Console.WriteLine("Stack Empty!");
                return default(int);
            }
        }
    }

    internal class _5_09
    {
        static void Main1(string[] args)
        {
            MyStack mStack = new MyStack();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int val = rand.Next(1, 100);
                mStack.Push(val);
                Console.WriteLine($"Push({val})");
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Pop() = {mStack.Pop()}");
            }
        }
    }
}
