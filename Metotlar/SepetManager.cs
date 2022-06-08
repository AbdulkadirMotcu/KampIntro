using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention 
        //syntax -- yazım değişimi
        public void Ekle(Urun urun) //Urun urun parametre- urunün bilgilerini ulaşmak için
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);    
        }

        //Birden Fazla Metot olabilir...     Yanlış yazım her eklediğin özelliği teker teker değiştirmek zorunda kalır
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //Urun.cs deki özellikleri burada yazıldı lakin sorunlu bir yapıdır
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
