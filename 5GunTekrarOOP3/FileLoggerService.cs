using System;

namespace _5GunTekrarOOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}