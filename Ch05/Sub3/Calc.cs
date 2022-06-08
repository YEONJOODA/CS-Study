using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub3
{
    internal class Calc
    {
        // 싱글톤 객체
        static Calc instance = new Calc();
        public static Calc Instance {  get { return instance; } }
        private Calc() { }

        public int Plus(int x, int y)
        {
            return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Multi(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            return (x / y);
        }
    }
}
