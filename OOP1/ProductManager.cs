using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager //CRID operasyon denir. "Ekleme silme listeleme değiştirme operasyonları"
    {
        //encapsulation -- Product'ın elemanlarını ulaşabilme
        public void Add(Product product)//string ad gibi /yani/ Product türünde bir veri gelecek ve product ismine tutacak.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)//void ile sadece yap veriyi geri alamayız
        {
            Console.WriteLine(product.ProductName + " güncellendi!");
        }

       
    }
}
