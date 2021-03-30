using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Claslarin iki kullanimi var. 1) bilgileri tutmagidi 2) operasyon tutuyor
//Classlarin sonunda Manager , Service , Dul ,DataAcsess , Controller kimi ifadeler varsa bunlar bir operasyon tutuyor
namespace Metotlar
{
    class Product
    {
        //Property - ozellik
        public int Id { get; set; }//Id bir datayi digerlerinden ayirt etmek icin kullandigimiz essiz degeri anlatir
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
