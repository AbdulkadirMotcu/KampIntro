using System;

namespace OPP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Individual musteri1 = new Individual();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kadir";
            musteri1.Soyadi = "Motcu";
            musteri1.TcNo = "12345678910";

            //Kodlama.io girişi

            Coorporate musteri2 = new Coorporate();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek - Tüzel birbirine yerine kullanılamaz
            //SOLID yazılım geliştirme tekniği

            //Customer (musteri) hem Individual'ın gerçek kişi hemde Coorporate'in tüzel kişi REFARANS NUMARISINI tutabilir..! 
            Customer musteri3 = new Individual();
            Customer musteri4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}
