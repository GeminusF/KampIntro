using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //MortgageLoanManager : (implement olundu) ILoanManagerdan
    class MortgageLoanManager : ILoanManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Dasinmaz emlak krediti odeme plani hesaplandi");
        }
    }
}
