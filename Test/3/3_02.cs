using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    class King
    {
        private string name;
        private int year;

        public King(int year) : this("정조")
        {
            this.year = year;
        }
        public King(string name)
        {
            this.name = name;
        }
        public King(string name, int year)
        {
                this.name = name;
                this.year = year;
        }
        public void Show()
        {
            Console.WriteLine("===================");
            Console.WriteLine("name : " + name);
            Console.WriteLine("year : " + year);
            Console.WriteLine("-------------------");
        }
    }

    internal class _3_02
    {
        static void Main1(string[] args)
        {
            King k1 = new King("태조", 1392);
            King k2 = new King("세종");
            King k3 = new King(1776);

            k1.Show();
            k2.Show();
            k3.Show();
        }
    }
}
