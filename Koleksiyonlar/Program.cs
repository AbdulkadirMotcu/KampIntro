using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array'ler cok fazla kullanılmaz
            //string[] isimler = new string[] { "Abdulkadir", "Engin", "Murat", "Kerem" }; // Arrayler ilk oluşturulduğu sırada takılır değiştirilemez
            //Console.WriteLine(isimler[0]); //Veri kaynağından gelir
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //new denildiği anda bellekte yeni alan oluşur 'referans'
            //isimler[4] = "ilker"; // yeni bir 5 elemanlı array oluşturulduğu için önceki değerleri isteyemiyoruz // istersek boş gelir
            //Console.WriteLine(isimler[4]);//index'in sınırları dışında hatası veirir 
            //Console.WriteLine(isimler[0]);//Gelmez çünkü BOŞ

            List<string> isimler2 = new List<string> {"Engin", "Murat" , "Kerem" ,"Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Abdulkadir"); //Eklemek için Add kullanıldı
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
