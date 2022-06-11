using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interface lerde onu iplemente edilen classın referce numarısnı tutabilir
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //ekrandaki açılır kutu
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();//database'e logla
            ILoggerService fileLoggerService = new FileLoggerService();//File logla

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new DatabaseLoggerService(), new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> () { new DatabaseLoggerService() , new SmsLoggerService() }); //Birden fazla değerde list<> içine alınır //krediler gibi list de yapılabilirdi
            basvuruManager.BasvuruYap(esnafKrediManager, loggers );

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager }; //seçilen krediler boş listeye atılır 

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);//BasvuruManagerdaki kodlar secilmiş
        }
    }
}
