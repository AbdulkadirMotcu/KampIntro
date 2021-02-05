using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncenlendi. ");
        }


             // return: toplanan sayıyı kullanmaya yarar bunu kullanmak istersek isek void kullanılmaz
             //void işi yap bırak demek
  
    }
}
