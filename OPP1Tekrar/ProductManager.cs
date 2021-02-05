using System;
using System.Collections.Generic;
using System.Text;

namespace OPP1Tekrar //CRUD operasyonlar var 
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        //public int Topla(int sayi1,int sayi2)
        //{
        //    return sayi1 + sayi2;
        //    //ortaya cıkan işlem sonucu kullanmamıza izin verir "return" bu işe yarar 
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2); 
        //}
    }

}
