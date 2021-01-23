using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //bunlar ekrandaki a.ılır kutular
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerServices();
            ILoggerService fileLoggerService = new FileLoggerServices();
            BasvuruManager basvuruManager = new BasvuruManager();

              basvuruManager.BasvuruYap(tasitKrediManager , databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager , tasitKrediManager};
          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
