using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elamsı";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //typr-safe -- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");


            }

            Console.WriteLine("-----------------Metotlar--------------");
            //instance - örenek
            //encapsulation 

            SepetMaganer sepetMaganer = new SepetMaganer();
            sepetMaganer.Ekle(urun1);
            sepetMaganer.Ekle(urun2);

            sepetMaganer.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetMaganer.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetMaganer.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}


//Dont repeat youtself - DRY kendini tekrar etme - Clean Code temiz kod - Best Practive doğru teknik
