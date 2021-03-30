using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {   
            //type safety - tip guvenligi
            //Do not repeat yourself - DRY
            //deger tutucu , alisa

            string katogoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faiziOrani = 1.45;
            bool sistemeGirisYapmis = true;

            double dolarDun = 7.85;
            double dolarBugun = 7.85;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Deyismedi Butonu");    
            }


            if (sistemeGirisYapmis == true) //double tab
            {
                Console.WriteLine("Kullanici Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(katogoriEtiketi);

            
        }  
    }    
}
