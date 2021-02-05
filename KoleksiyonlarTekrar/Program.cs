using System;
using System.Collections.Generic;

namespace KoleksiyonlarTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Kadir", "Mustafa", "Cihan", "Halit", "Harun" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);

            //isimler = new string[6];
            //isimler[5] = "Abdulkadir";
            //Console.WriteLine(isimler[5]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Kadir", "Mustafa", "Cihan", "Halit" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Harun");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //list in array lerden farkı değerleri kaybetmemize yarayan sistem vardır.

        }
    }
}
