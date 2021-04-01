using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {   // ILoanManager loanManager men bunu yazandan sonra uje her 3 loanimi uzerinden basvuruyapa bilerem
        // Biz bura transportloan gonndersek onun hesaplasi bellekde calisir mortgageloan gondersek onun
        // hesaplasi bellekde calisir financeloan gondersem onun hesaplasi bellekde calisir

        // Bu bilgi texniki mulakata girende mutleq qarsimiza cixacaq ve meni o ise soxacaq bilgidir.
        // Cunki bununla artiq menimcun soyutlama(abstractizm) tamam ile hell olur 

        //Method injection
        //dependency enjiction

        public void BasvuruYap(ILoanManager loanManager , List<ILoggerService> loggerServices) 
        {
            //Basvuran bilgilerini degerlendirme
            //

            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Hesapla();
            // bu kod isleyer amma tum basvurular konut kredisi uzerinden hesaplanir

            loanManager.Hesapla();
            foreach (ILoggerService logs in loggerServices)
            {
                logs.Log();
            }
            
        }

        public void DoLoanPreviewInformation(List<ILoanManager> loans) 
        {
            foreach (ILoanManager loan in loans)
            {
                loan.Hesapla();
            }
        }
    }
}
