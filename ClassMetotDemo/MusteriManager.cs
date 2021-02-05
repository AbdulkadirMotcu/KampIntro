using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekleme(Musteri musteri) 
        {
            Console.WriteLine("Yeni müşteri eklenmiştir:" + "Id:"+musteri.Id + " " +"Adı: "+ musteri.Ad +" " + " Soyadı:"+ musteri.Soyad);
        }

        public void silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silinmiş:" + "Id:" + musteri.Id + " " + "Adı: " + musteri.Ad + " " + " Soyadı:" + musteri.Soyad);
        }

        public void listeleme(Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("Id: "+musteriler[i].Id+ " " +" Adı:" +   musteriler[i].Ad + " " +"Soyadı:"+ musteriler[i].Soyad);
            }
        }
    }
}
