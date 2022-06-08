using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Yetiştirme Kurs";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array - dizi birden fazka değer tutmak için kullanılır

            string[] kurslar = new string[] { "Yazılım Geliştirme Yetiştirme Kurs", "Programlamaya başlangıç için temel kurs", "Java" ,"Python"};

            //For Döngüsü tekrarlanması istenilen kod satırının ya da kod bloğunun,
            //belirtilen sayı kadar, belirlenen şart sağlanana kadar ve istenen artış ya da azalış sayısı kadar tekrarlanmasını sağlayan döngü yapısıdır.
            //1'den başla 10'a kadar devam et ve bir bir arttır
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            //Dizi temelli yapıları tek tek dönmeye yarar kurslar (foreach dizilere uygulanır)
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");

            string kurss1 = "Yazılım Geliştirici Yetiştirici Kampı";
            string kurss2 = "Programlamaya başlangıç için temel kurs";
            string kurss3 = "Java";

            //array - Diziler de tutulur
            //istediğim kadar ürünü tutabilir-- birden fazla tutar
            string[] kurslarr = new string[] { "Yazılım Geliştirici Yetiştirici Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python"};


            for (int i = 0; i < kurslarr.Length; i++)
            {
                Console.WriteLine(kurslarr[i]);
            }

            Console.WriteLine("-------------for döngüsü bitti-------------");

            foreach (string kurs in kurslarr)  
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
