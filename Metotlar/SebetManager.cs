using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SebetManager
    {
        //naming convetion
        //parameters - metotda eklediyimiz
        public void Elave(Product urun)
        {
            Console.WriteLine("Tebrikler. Sebete " + urun.Adi + " Elave Olundu! : ");

        }
        // hatali kullanim cox adam eleyir bu sehvi , parametreler deyisende kod patlayir
        public void Elave2(string urunAdi , string aciklama , double fiyat , int stokEdedi) 
        {
            Console.WriteLine("Tebrikler. Sebete " + urunAdi + " Elave Olundu! : ");
        }
    }
}
