using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 Numara Mobilyaya ednk gelmektedir. düşün
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5 , UnitInStock = 5, //Bu şekilde yazılır
                ProductName = "Kalem", UnitPrice = 35  };//Normelde bu veriler veri tabanından gelir, ekrandan kullanıcıdan alınır.

            //PascalCase    //camelCase   İsimlendirme kuralları önemli !!!!
            //case sensitive küçük BÜYÜK harf Duyarlı
            // ProductManager türündeki productManager(Takma isim 'x' olur) yeni bir referans numarısı almış ProductManager türünde productManager('takma isim')
            // Stack                        //Heap
            ProductManager productManager = new ProductManager(); // Örnek oluşturmak denir ProductManager türünde ProductManager tanımlandı
            productManager.Add(product1); //product1'i ProductManager'e işlenmesi için gönderir
            Console.WriteLine(product1.productManager);

           
            

            //int,double,bool.... değer tip
            //dizler, clss, abstract class, interdace ... referance tip referansın numarı ile işlem yapılır. bellekteki numara
        }
    }
}
