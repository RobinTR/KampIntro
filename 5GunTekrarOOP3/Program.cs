using System;
using System.Collections.Generic;

namespace _5GunTekrarOOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            List<IKrediManager> krediler = new List<IKrediManager>() { konutKrediManager, tasitKrediManager };

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);
            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { databaseLoggerService,smsLoggerService} );
            List<ILoggerService> loggerServices = new List<ILoggerService>() { smsLoggerService, fileLoggerService };
            basvuruManager.BasvuruYap(tasitKrediManager,loggerServices);


            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
