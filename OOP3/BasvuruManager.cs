using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //Her kredinin referance nı tutabilen IKrediManager yazılır tüm kredi bilgileri 
        {
            //Başvuran biligilerini değerlendirme

            //hangi kredinin referance numarısını gönderilirse o çalışacaktır..
            krediManager.Hesapla();
            foreach (var loggres in loggerServices)
            { 
                loggres.Log();
            }

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();//Tüm başvuruları konut kredisine bağımlı hale geldi ve kullanımı doğru değildir

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Birden fazla krediyi hesaplamak için list kullanılır listin türü IKrediManager
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();//Listedeki her bir kredinin hesaplasını çağır
            }
        } 
    }
}
