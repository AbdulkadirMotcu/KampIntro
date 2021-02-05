using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] ismler = new string[] { "Engin ", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(ismler[0]);
            //Console.WriteLine(ismler[1]);
            //Console.WriteLine(ismler[2]);
            //Console.WriteLine(ismler[3]);

            //ismler = new string[5];
            //ismler[4] = "ilker";
            //Console.WriteLine(ismler[4]);
            //Console.WriteLine(ismler[0]);

            List<string> isimler2 = new List<string> {"Engin ", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            isimler2
        }
    }
}
