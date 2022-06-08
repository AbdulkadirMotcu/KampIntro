using System;

namespace OdevIkinciHaftaProductSıralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products products1 = new Products();
            products1.ProductName = "Iphone 12";
            products1.ProductPrice = 13.999;

            Products products2 = new Products();
            products2.ProductName = "Asus Notebook";
            products2.ProductPrice = 5000;

            Products products3 = new Products();
            products3.ProductName = "Kingston 8GB Ram";
            products3.ProductPrice = 623.99;

            Products[] products = new Products[] { products1, products2, products3};

            foreach (Products product in products)
            {
                Console.WriteLine(product.ProductName + " " + product.ProductPrice);
            }
            Console.WriteLine("Foreach Dögüsü Bitti");

            Console.WriteLine("For Dögüsü Başladı");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " " +products[i].ProductPrice);
            }

            Console.WriteLine("for Dögüsü Bitti");

            Console.WriteLine("While Dögüsü Başladı");

            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].ProductName + " " + products[a].ProductPrice);
                a++;
            }
        }

    }
    class Products
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

    }
}
