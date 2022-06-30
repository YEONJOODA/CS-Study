using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    class Products
    {
        List<Product> list = new List<Product>();

        public void SetProduct(string item, int price)
        {
            Product product = new Product();
            product.SetItem(this, item, price);
        }

        public void ShowList()
        {
            foreach (Product p in list)
            {
                Console.WriteLine("상품 : {0}, 가격 : {1:C}", p.GetItem(), p.GetPrice());
            }
        }

        private class Product
        {
            private string item;
            private int price;

            public void SetItem(Products outer, string item, int price)
            {
                this.item = item;
                this.price = price;

                outer.list.Add(this);
            }

            public string GetItem()
            {
                return item;
            }

            public int GetPrice()
            {
                return price;
            }
        }
    }

    internal class _4_05
    {
        static void Main5(string[] args)
        {
            Products products = new Products();
            products.SetProduct("신발", 30000);
            products.SetProduct("셔츠", 20000);
            products.SetProduct("바지", 15000);
            products.ShowList();
        }
    }
}
