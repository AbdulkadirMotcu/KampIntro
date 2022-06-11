using System;

namespace OOP3
{
    internal class FileLoggerService : ILoggerService
    {
        //Log= bir işlemin yapıldığına dair yapılan işlem *açıklama kaydı
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
