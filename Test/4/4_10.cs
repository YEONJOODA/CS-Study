using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._4
{
    class Human
    {
        private string name;

        public Human(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine(name + " 입니다.");
        }
    }

    class Worker : Human
    {
        public Worker(string name) : base(name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("작업을 합니다.");
        }
    }

    class Developer : Human
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("개발을 합니다.");
        }
    }

    class Professor : Human
    {
        public Professor(string name) : base(name)
        {

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("연구를 합니다.");
        }
    }

    internal class _4_10
    {
        static void Main1(string[] args)
        {
            Worker worker = new Worker("김유신");
            Developer developer = new Developer("김춘추");
            Professor professor = new Professor("장보고");

            Human[] people = { worker, developer, professor };

            foreach (Human human in people)
            {
                human.Show();
                Console.WriteLine();
            }
        }
    }
}
