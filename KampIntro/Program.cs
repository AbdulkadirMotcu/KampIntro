using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler veri tutuculardır.
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini Tekrarlama

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmisMi = false; //Burası gerçekte veri kaynağından gelir -- bakar.
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarBugun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            
            if (sistemeGirişYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            /*int sayi = Int32.Parse(Console.ReadLine());

            switch (sayi)
            {

                case 1: Console.WriteLine("Pazartesi"); break;
                case 2: Console.WriteLine("Salı"); break;
                case 3: Console.WriteLine("Çarşamba"); break;
                case 4: Console.WriteLine("Perşembe"); break;
                case 5: Console.WriteLine("Cuma"); break;
                case 6: Console.WriteLine("Cumartesi"); break;
                case 7: Console.WriteLine("Pazar"); break;

                default: Console.WriteLine("Hata Böyle bir gün yok"); break;
            }

            Console.ReadLine();*/


        }
    }
}
