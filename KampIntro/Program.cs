using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias 
            //bool sisteme giriş yapmış yada yapmamış

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            //--------------------------------------

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
