using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{   // Imzanin eyni oldugu amma icerisinin ferqli oldugu durumlarda interface istifade eleyirik
    // Interface menim sablonumdu 
    // Interface :  eyerki birisi bu interface kullanirsa o arkadasim bu metod(lari)u icermek zorunda
    // Oxunurlugu artirmag ucun Interfaceleri I herfi ile basladiriq
    // Genellikle operasyon methodlarda kullanilir interfaceler
    // Interfaceler de  o interface implement eden classin referans.no tuta bilir 
    interface ILoanManager
    {
        void Hesapla();
        void BiseyYap();
    }

    // Pis programlamaci interface yerine class tanimlayir Hesaplanin icine int krediTuru deyir if krediTuru = 1
    // ise bunu ele 2 ise bunu ele deyir. Sen eleme!

    // * Interfaceleri bir birinin alternatifi olan amma kod icerikleri farkli olan durumlar icin kullaniriz

}
