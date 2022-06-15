using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P289
    {
        class Product
        {
            public string name;
            public int price;

            public Product(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

            ~Product()
            {
                Console.WriteLine(this.name + "의 소멸자 호출");
            }
        }

        static void Main1(string[] args)
        {
            Product product = new Product("과자", 1000);
        }
    }
}
