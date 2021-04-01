using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{   // interfacelere service deyecem

    // loglama - kim nezaman hangi operasyonu cagirdirdi. bir nevi o sistemde olan hareketleri dokduyumuz dokum-
    // dur. loglammanin ferqli yontemleri loglari dosya da , veri tabaninda tuta bilerim , sms olaraq ata bilerim,
    // e-mail yolaya bilerem

    interface ILoggerService
    {
        void Log();
    }
}
