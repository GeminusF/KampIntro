using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager financeLoanManager = new FinanceLoanManager();
            ILoanManager transportLoanManager = new TransportLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService loggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.BasvuruYap(mortgageLoanManager , new DatabaseLoggerService());
            //applicationManager.BasvuruYap(transportLoanManager, loggerService);
            //applicationManager.BasvuruYap(new ArtisanLoanManager(), new SmsLoggerService());

            List<ILoggerService> loggers = new List<ILoggerService> 
            { 
                new FileLoggerService() ,
                new SmsLoggerService()
                };

            applicationManager.BasvuruYap(new ArtisanLoanManager(), loggers);

            /*applicationManager.BasvuruYap(new ArtisanLoanManager(), new List<ILoggerService>() 
            { 
                new DatabaseLoggerService(),
                new SmsLoggerService()
            });*/

            List <ILoanManager> loans = new List<ILoanManager>() { financeLoanManager , transportLoanManager  };

            //applicationManager.DoLoanPreviewInformation(loans);
        }
    }
}
