using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._4
{
    class Employee
    {
        public string Name { get; set; } = "홍길동";
        public string Position { get; set; } = "사원";

        public void Show()
        {
            Console.WriteLine("===================");
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("직급 : " + Position);
            Console.WriteLine("-------------------");
        }
    }

    internal class _4_03
    {
        static void Main1(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Show();
            Employee emp2 = new Employee()
            { Name = "김유신", Position = "대리" };
            emp2.Show();
            Employee emp3 = new Employee() { Name="김춘추", Position="과장"};
            emp3.Show();
        }
    }
}
