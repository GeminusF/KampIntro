using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{   //Classda ozellik tutdugumuz yerde operasyon tutmuyoruz , operasyon tutdugumuz yerde ozellik tutmuyoruz
    //TcNo ve TaxNo niye long yox stringdi? Bir veri uzerinde matematiksel islemler yapilmiyorsa metinsel olaraq planlanirsa daha iyi sonuclar alinir xususiylede ferqli sistemlerle veri uyumlulugunda
    // *Egerki bir nesnede bir deyeri kullanmak zorunda gibi gorunmuyorsan o nesneye adi deyilmis gibi
    // duruyorsa o alan demekki orada hata yapiyorsun  , soyutlama hatasi yapiyorsun deriz
    //Base Sinif - temel sinif

    //Olay Base sinifin yani Customerin onu inherit eden Corporate , Individual-in referansi tuta bilmesi
    // Eger menin Base sinifim varsa O sinif referans tutucudur
    class Customer
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
    }

}
