using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //SOLID-in O herfi  open-close principal deyirki sisteme yeni xusisiyet elave olunanda movcud kodlar bozulmaz

    class ArtisanLoanManager : ILoanManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Sahibkar krediti hesaplandi");
        }
    }
}
