using System;

namespace ClassDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<=10) 
            {
                Console.WriteLine("Yaz işte");
                i++;
            }
            Console.ReadLine();//bitti burda kod 

            urunOzellikleri urun1 = new urunOzellikleri();
            urun1.urunAdı = "Maske";
            urun1.urunUcret = 5;
            urun1.urunStok = 100;

            urunOzellikleri urun2 = new urunOzellikleri();
            urun2.urunAdı = "Eldiven";
            urun2.urunUcret = 0.50;
            urun2.urunStok = 10000;

            urunOzellikleri urun3 = new urunOzellikleri();
            urun3.urunAdı = "Gözlük";
            urun3.urunUcret = 500;
            urun3.urunStok = 50;

            urunOzellikleri[] urunler = new urunOzellikleri[] {urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı:"+urun.urunAdı + " " + " Ücret:" +urun.urunUcret + " " + "Stok "+urun.urunStok);
            }

        }
    }
    class urunOzellikleri
    {   //prop (property)'den özellik demek gelir yaz!!
        public string urunAdı { get; set; }
        public double urunUcret { get; set; }
        public int urunStok { get; set; }
    }
}
