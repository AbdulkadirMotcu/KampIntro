using System;
using System.Collections.Generic;
using System.Text;

namespace MetotlarTekrar
{
    class SepetManager
    {
        //naming convertion   //normal pareter görürsek () orada metot çalışıyordur
        //syntax - yazım şekilleri
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " +urun.Adi );
        }

        //bunu yapma encapsulation yukarıdaki gibi
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
