using System;
using System.Collections.Generic;

namespace GenericsIntroTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mylist<string> isimler = new Mylist<string>();
            isimler.Add("Kadir");

            Console.WriteLine("Hello World!");
        }
    }
}
