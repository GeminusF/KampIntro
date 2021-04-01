using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{   //Varlik - Entitydi bu operasyon ola bilmez icinde
    //inheritance
    // Corporate:Customer corporate bir customerdi demekdi bu
    // :  javadaki extends
    class Corporate : Customer
    {
        public string CorporationName { get; set; }
        public string TaxNo { get; set; }
    }
}
