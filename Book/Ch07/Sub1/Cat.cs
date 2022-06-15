using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class Cat
    {
        public int Age { get; set; }

        public Cat() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }

    }
}
