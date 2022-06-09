using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Sedan : Car
    {
        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("차량명 : "+ name);
            Console.WriteLine("차량색 : "+ color);
            Console.WriteLine("차량속도 : "+ speed);
            Console.WriteLine("차량배기량 : "+cc);
            Console.WriteLine("-----------------");
        }
    }
}
