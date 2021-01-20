using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamaya Başlangış";
            string kurs3 = "Java";
            string kurs4 = "Pyton";
            string kurs5 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


            //array - dizi

            string[] kurslar = new string[] { "Yazılımcı Geliştirici Yetiştirme Kampı", 
                    "Proglamaya Başlangış için temel kurs", "Java","Pyton","C#" };

            //kurslar.length ne kadar eleman varsa yazar length elaman demek;;;

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            
            Console.WriteLine("for bitti");
            //var = variable = değişken
            foreach (string kurs in kurslar)    //foreach dizileri tek tek dolaşmaya yarar i ye gerek kalmaz 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
