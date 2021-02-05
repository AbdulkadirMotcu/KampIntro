using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id=010101;
            musteri1.Ad = "Abdulkadir";
            musteri1.Soyad = "Motcu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 010102;
            musteri2.Ad = "Mustafa";
            musteri2.Soyad = "Kabacan";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 010103;
            musteri3.Ad = "Leyla";
            musteri3.Soyad = "Kahraman";


           

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Ekle");
            musteriManager.ekleme(musteri1);
            musteriManager.ekleme(musteri2);
            Console.WriteLine("---------------------");

            Console.WriteLine("------------Silme---------------");
            musteriManager.silme(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            Console.WriteLine("-----------Listeleme-----------");
            musteriManager.listeleme(musteriler);
        


        }
    }
}
