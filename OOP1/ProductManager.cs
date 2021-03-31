using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager // ve ya ProductService deye adlanilir esassen productla elaqeli operasyonlar vaar eger adlar beledise
    {
        //encapsulation
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " guncellendi.");
        }

        

        //islem sonucunu be olduguyla ilgili bir bilgiye ihtiyacimiz yok o zaman void tanimlayiyoruz. void emir kipidi sadece git filan seyi yap fsyo
        //returnden istifade eleye bilirik programin akisinda meselen donduruyu int deyerini vura bole , uzerinde ferqli emeller eleye bilerik programin akisinda mene o deyer lazim 
                
    }

}
