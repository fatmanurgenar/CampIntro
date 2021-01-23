using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {   //method injection
        public void BasvuruYap(IKrediManager krediManager ,ILoggerService loggerService)
        {
            //çeşitli bilgiler alırız mesela-->basvuran bilgilerini değerlendirme 
            //
            //krediyi hesaplayalım 
            //
           // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           // ihtiyacKrediManager.Hesapla(); --> diğer kredi türleri ne olacak 

            krediManager.Hesapla();
            loggerService.Log();
        }
        //bana bşr liste ver ama listenin türü IKrediManager olsun..
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
 
        }
    }
}
