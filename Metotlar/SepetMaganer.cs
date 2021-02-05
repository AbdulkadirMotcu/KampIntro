using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetMaganer
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string urunAciklama, double Fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + urunAdi);
        }

        
      
    }
}
